namespace First_Demo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            //var result = MessageBox.Show("Hello, World!\nHello, World!\nHello, World!\nHello, World!\nHello, World!\n", "My dialog",
            //    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            //MessageBox.Show(result.ToString(), "Your choice");

            //if (result == DialogResult.OK)
           // {
                Application.Run(new Form2());
            //}
            //else
            //{
            //    MessageBox.Show("You didn't click OK", "Bye");
            //}
        }
    }
}