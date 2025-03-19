namespace EvidencePojisteni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InsurerManager insurerManager = new InsurerManager();
            UserInterface userInterface = new UserInterface(insurerManager);

            userInterface.ShowMainMenu();
        }
    }
}
