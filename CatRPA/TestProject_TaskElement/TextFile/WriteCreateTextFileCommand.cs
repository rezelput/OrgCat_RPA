namespace TextFile
{
    internal class WriteCreateTextFileCommand
    {
        internal string v_FilePath;

        public string v_TextToWrite { get; internal set; }
        public string v_Overwrite { get; internal set; }
    }
}