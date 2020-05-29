namespace SOLID.LSP.Example1
{
    public class Square : Rectangle
    {
        // this won't work with upcasting
        //public new int Width
        //{
        //    set => base.Width = base.Height = value;
        //}
        //public new int Height
        //{
        //    set => base.Height = base.Width = value;
        //}

        public override int Width
        {
            set => base.Width = base.Height = value;
        }

        public override int Height
        {
            set => base.Height = base.Width = value;
        }
    }
}