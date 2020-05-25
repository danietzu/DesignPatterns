namespace State
{
    public class Canvas
    {
        private ITool _currentTool;

        public ITool CurrentTool { get => _currentTool; set => _currentTool = value; }

        public void MouseDown() => _currentTool.MouseDown();

        public void MouseUp() => _currentTool.MouseUp();
    }
}