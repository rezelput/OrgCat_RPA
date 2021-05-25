using sharpRPA.Commands.Task.Test;
using System;

namespace sharpRPA.Commands.Variable
{
    internal class SetVariableCommand
    {
        public string v_Input { get; internal set; }
        public string v_OutputUserVariableName { get; internal set; }

        internal void RunCommand(AutomationEngineInstance engine)
        {
            throw new NotImplementedException();
        }
    }
}