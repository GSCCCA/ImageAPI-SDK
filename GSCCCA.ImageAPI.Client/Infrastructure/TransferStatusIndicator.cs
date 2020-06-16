using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GSCCCA.ImageAPI.Client.Infrastructure
{
    public enum CurrentEventType
    {
        FileStarting,
        FileCompleted,
        FileError

    }
    public class TransferStatusEventArgs : EventArgs
    {
        

        public TransferStatusEventArgs(int totalFiles, int completedFiles, CurrentEventType currentEvent, string filePath, string error)
        {
            TotalFiles = totalFiles;
            CompletedFiles = completedFiles;
            CurrentEvent = currentEvent;
            FilePath = filePath;
            Error = error;
        }
        public int TotalFiles { get; }
        public int CompletedFiles { get; }
        public CurrentEventType CurrentEvent { get; }
        public string FilePath { get; }
        public string Error { get; }

    }

    public class TransferStatusIndicator
    {
        private volatile int _currentFile;
        private volatile bool _isComplete = false;
        public int TotalFiles { get; internal set; }

        internal void SetComplete()
        {
            _isComplete = true;
        }

        public bool IsComplete => _isComplete;

        public SynchronizationContext ThreadContext { get; }

        public TransferStatusIndicator()
        {
            ThreadContext = null;
        }

        public TransferStatusIndicator(SynchronizationContext threadContext)
        {
            ThreadContext = threadContext;
        }

        private void FireUpdateEvent(CurrentEventType currentEvent, string filePath, string error)
        {
            if (StatusUpdate != null)
            {
                if (ThreadContext == null)
                {
                    StatusUpdate(this, new TransferStatusEventArgs(TotalFiles, _currentFile, currentEvent, filePath, error));
                }
                else
                {
                    ThreadContext.Post(s =>
                    {
                        StatusUpdate(this, new TransferStatusEventArgs(TotalFiles, _currentFile, currentEvent, filePath, error));
                    }, null);
                }
            }
        }

        internal void UpdateMessage(string path, CurrentEventType currentEvent, string error)
        {
            if (currentEvent == CurrentEventType.FileCompleted || currentEvent == CurrentEventType.FileError)
            {
                CompletedFiles++;
            }
            FireUpdateEvent(currentEvent,path, error);
        }



        public int CompletedFiles
        {
            get => _currentFile;
            private set
            {
                if (_currentFile < value)
                {
                    _currentFile = value;
                }
            }
        }

        public event EventHandler<TransferStatusEventArgs> StatusUpdate;

    }
}
