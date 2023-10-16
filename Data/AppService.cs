using QuizzProject.Models;

namespace QuizWithBlazor.Data
{
    public static class AppService
    {
        private static QuizService service = new QuizService();
        public static int index = 0;
        public static void Start(string difficulty,string playerName)
        {
            service.playerName = playerName;
            service.selectedDifficulty = difficulty;
            service.StartQuizz();
        }

        public static Question GetCurrentQuestion()
        {
            return service.GetQuestion(index);
        }

        public static void CheckAnswers(List<bool> answers)
        {
            service.CheckQuestionAnswer(index, answers);
        }

        public static void AddStats()
        {
            service.AddPlayerStats();
        }

        public static void NewQuiz()
        {
            index = 0;
            service.NewQuiz();
        }

        public static int Score => service.playerScore;
        public static string PlayerName => service.playerName;
        public static string Difficulty => service.selectedDifficulty;
        public static List<Player> Players=>service.GetAllPlayers();
    }
}
