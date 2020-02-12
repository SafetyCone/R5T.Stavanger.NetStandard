using System;
using System.Runtime.InteropServices.ComTypes;


namespace R5T.Stavanger.NetStandard
{
    public class ShortcutOperator : IShortcutOperator
    {
        public string CreateShortcut(string shortcutFilePath, string shortcutTargetPath, string description)
        {
            IShellLink link = (IShellLink)new ShellLink();

            // setup shortcut information
            //link.SetDescription();
            link.SetPath(shortcutTargetPath);

            // save it
            IPersistFile file = (IPersistFile)link;
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            file.Save(shortcutFilePath, false);

            return shortcutFilePath;
        }

        public string GetShortcutDescription(string shortcutFilePath)
        {
            throw new NotImplementedException();
        }

        public string GetShortcutTargetPath(string shortcutFilePath)
        {
            throw new NotImplementedException();
        }

        public void SetShortcutDescription(string shortcutFilePath, string description)
        {
            throw new NotImplementedException();
        }

        public void SetShortcutTargetPath(string shortcutFilePath, string shortcutTargetPath)
        {
            throw new NotImplementedException();
        }
    }
}
