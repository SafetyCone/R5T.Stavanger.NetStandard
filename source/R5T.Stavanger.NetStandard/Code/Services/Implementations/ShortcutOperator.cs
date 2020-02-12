using System;
using System.Runtime.InteropServices.ComTypes;


namespace R5T.Stavanger.NetStandard
{
    public class ShortcutOperator : IShortcutOperator
    {
        private IShortcutPathConventions ShortcutPathConventions { get; }


        public ShortcutOperator(IShortcutPathConventions shortcutPathConventions)
        {
            this.ShortcutPathConventions = shortcutPathConventions;
        }

        public string CreateShortcut(string shortcutFilePath, string shortcutTargetPath, string description)
        {
            var link = new ShellLink() as IShellLink;

            link.SetDescription(description);
            link.SetPath(shortcutTargetPath);

            var file = link as IPersistFile;

            var shortcutLinkFilePath = this.ShortcutPathConventions.MakeFilePathIntoLinkFilePath(shortcutFilePath);
            file.Save(shortcutLinkFilePath, false);

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
