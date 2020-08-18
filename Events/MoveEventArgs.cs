using System.Collections.Generic;
using System.ComponentModel;
using Shoko.Plugin.Abstractions.DataModels;

namespace Shoko.Plugin.Abstractions
{
    /// <summary>
    /// The event arguments for a Move event. It can be cancelled by setting Cancel to true or skipped by not setting the result parameters.
    /// </summary>
    public class MoveEventArgs : CancelEventArgs
    {
        /// <summary>
        /// The available import folders to choose as a destination. You can set the <see cref="DestinationImportFolder"/> to one of these.
        /// If a Folder has <see cref="DropFolderType.Excluded"/> set, then it won't be in this list.
        /// </summary>
        public List<IImportFolder> AvailableFolders { get; set; }
        
        /// <summary>
        /// Information about the file itself, such as MediaInfo
        /// </summary>
        public IVideoFile FileInfo { get; set; }

        /// <summary>
        /// Information about the Anime, such as titles
        /// </summary>
        public IAnime AnimeInfo { get; set; }
        
        /// <summary>
        /// The base import folder that the file will go in. This must be valid if the file is to be moved.
        /// </summary>
        public IImportFolder DestinationImportFolder { get; set; }
        
        /// <summary>
        /// The "Result", or the relative location from the <see cref="DestinationImportFolder"/> that the file will go. It is highly recommended to use Path.Combine() when dealing with subdirectories.
        /// </summary>
        public string DestinationPath { get; set; }
    }
}