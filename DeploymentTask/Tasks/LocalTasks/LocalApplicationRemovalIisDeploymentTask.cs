using System;
using System.Text.RegularExpressions;
using DeploymentConfiguration.Actions;

namespace DeploymentTask.Tasks.LocalTasks
{
    public class LocalApplicationRemovalIisDeploymentTask : LocalRemovalIisDeploymentTaskBase
    {
        public LocalApplicationRemovalIisDeploymentTask(IisActionComponentGraph actionComponentGraph) : base(actionComponentGraph)
        {
        }

        public override string DisplayName
        {
            get { throw new NotImplementedException(); }
        }

        public override int ExpectedReturnValue
        {
            get { throw new NotImplementedException(); }
        }

        protected override string CreateParameterString(string parameter)
        {
            throw new NotImplementedException();
        }

        protected override string CmdFileName
        {
            get { throw new NotImplementedException(); }
        }

        protected override string CmdFileNameExtension
        {
            get { throw new NotImplementedException(); }
        }

        protected override string CmdFileNameExe
        {
            get { throw new NotImplementedException(); }
        }

        protected override string CmdFileParameterDestinationPath
        {
            get { throw new NotImplementedException(); }
        }

        protected override Regex ConfigFileNamePattern
        {
            get { throw new NotImplementedException(); }
        }
    }
}