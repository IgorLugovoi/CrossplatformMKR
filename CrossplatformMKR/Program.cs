namespace CrossplatformMKR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1 task = new Task1();
            int result = task.TaskSolution();
            //File.WriteAllText(@"MKR\output.txt", $"{result}");
            File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\output.txt"), $"{result}");
        }
    }
}
