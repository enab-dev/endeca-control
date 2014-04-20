using EndecaControl.EacToolkit.Core;

namespace EndecaControl.EacToolkit.Components
{
    public sealed class DgidxComponent : BatchComponent
    {
        internal DgidxComponent(string compId, string appId, HostType host)
            : base(compId, appId, host)
        {
        }

        public bool ArchiveIndex()
        {
            var token = BackupFiles(OutputDirectory, 1);
            return WaitUtilityComplete(token);
        }
    }
}