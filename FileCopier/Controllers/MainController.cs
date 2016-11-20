using FileCopier.Views;
using HotBinder.Core.Attributes;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using HotBinder.Core;
using HotBinder.Core.Binding.Commands;

namespace FileCopier.Controllers
{
	public class MainController : Controller
	{
		private bool isSourceValid;
		private bool isDestinationValid;
		private bool isInProgress;

		private string sourcePath;
		private string destinationPath;

		private int filesCount;
		private int filesDone;

		private ICommand chooseSourceCommand;
		private ICommand chooseDestinationCommand;
		private ICommand copyCommand;

		public bool IsSourceValid
		{
			get { return isSourceValid; }
			set
			{
				SetProperty(ref isSourceValid, value);
				OnPropertyChanged(nameof(IsReadyToCopying));
			}
		}

		public bool IsDestinationValid
		{
			get { return isDestinationValid; }
			set
			{
				SetProperty(ref isDestinationValid, value);
				OnPropertyChanged(nameof(IsReadyToCopying));
			}
		}

		public bool IsInProgress
		{
			get { return isInProgress; }
			set
			{
				SetProperty(ref isInProgress, value);
				OnPropertyChanged(nameof(IsReadyToCopying));
			}
		}

		public bool IsReadyToCopying
		{
			get { return IsSourceValid && IsDestinationValid && !IsInProgress; }
			set { }
		}

		public string SourcePath
		{
			get { return sourcePath; }
			set
			{
				SetProperty(ref sourcePath, value);
				IsSourceValid = IsPathValid(value);
			}
		}

		public string DestinationPath
		{
			get { return destinationPath; }
			set
			{
				SetProperty(ref destinationPath, value);
				IsDestinationValid = IsPathValid(value);
			}
		}

		public int FilesCount
		{
			get { return filesCount; }
			set
			{
				SetProperty(ref filesCount, value);
			}
		}

		public int FilesDone
		{
			get { return filesDone; }
			set
			{
				SetProperty(ref filesDone, value);
			}
		}

		public ICommand ChooseSourceCommand
		{
			get { return chooseSourceCommand; }
			set
			{
				SetProperty(ref chooseSourceCommand, value);
			}
		}

		public ICommand ChooseDestinationCommand
		{
			get { return chooseDestinationCommand; }
			set
			{
				SetProperty(ref chooseDestinationCommand, value);
			}
		}

		public ICommand CopyCommand
		{
			get { return copyCommand; }
			set
			{
				SetProperty(ref copyCommand, value);
			}
		}

		public MainController()
		{
			ChooseSourceCommand = new RelayCommands(ChooseSourceCommandExecute);
			ChooseDestinationCommand = new RelayCommands(ChooseDestinationCommandExecute);
			CopyCommand = new RelayCommands(CopyCommandExecute);
		}

		private void CopyCommandExecute(object obj)
		{
			Task copyTaks = Task.Factory.StartNew(() =>
			{
				CopyFileAsync();
			});
		}

		private void CopyFileAsync()
		{
			try
			{
				IsInProgress = true;

				FilesDone = 0;
				var filesToCopy = Directory.GetFiles(SourcePath);
				FilesCount = filesToCopy.Length;
				for (int i = 0; i < FilesCount; i++)
				{
					var sourceFullPath = Path.Combine(SourcePath, filesToCopy[i]);
					var destinationFullPath = Path.Combine(DestinationPath, filesToCopy[i]);

					File.Copy(sourceFullPath, destinationFullPath, true);
					FilesDone++;
				}
			}
			catch (Exception e)
			{
				MessageBox.Show("Copying files failed. Because:" + e.Message);
			}
			finally
			{
				IsInProgress = false;
			}
		}

		private bool IsPathValid(string path)
		{

			if (!Directory.Exists(path))
			{
				return false;
			}
			return true;
		}

		private void ChooseDestinationCommandExecute(object obj)
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				DestinationPath = dialog.SelectedPath;
			}
		}

		private void ChooseSourceCommandExecute(object obj)
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				SourcePath = dialog.SelectedPath;
				IsSourceValid = true;
			}
		}

		#region Actions

		[Action]
		public void Index()
		{
			var view = new MainView(this);

			Host.ApplyView(view);
		}

		#endregion Actions
	}
}
