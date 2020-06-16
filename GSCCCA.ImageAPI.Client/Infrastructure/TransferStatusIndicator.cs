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
        private volatile int _completedFiles;
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
                int completedFiles = 0;
                lock (this)
                {
                    completedFiles = _completedFiles;
                }

                if (ThreadContext == null)
                {
                    StatusUpdate(this, new TransferStatusEventArgs(TotalFiles, completedFiles, currentEvent, filePath, error));
                }
                else
                {
                    ThreadContext.Post(s =>
                    {
                        StatusUpdate(this, new TransferStatusEventArgs(TotalFiles, completedFiles, currentEvent, filePath, error));
                    }, null);
                }
            }
        }

        internal void UpdateMessage(string path, CurrentEventType currentEvent, string error)
        {
            if (currentEvent == CurrentEventType.FileCompleted || currentEvent == CurrentEventType.FileError)
            {
                lock (this)
                {
                    _completedFiles++;
                }
            }
            FireUpdateEvent(currentEvent,path, error);
        }





        public event EventHandler<TransferStatusEventArgs> StatusUpdate;

    }
}
