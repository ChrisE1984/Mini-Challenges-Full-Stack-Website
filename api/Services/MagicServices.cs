
namespace api.Services
{
    public class MagicServices : IMagicServices
    {
        public string Answer(string input)
        {
            List<string> answers =
            [
                "It is certain!",
                "Without a doubt!",
                "Most likely!",
                "Ask again later!",
                "Cannot predict now",
                "My reply is no!",
                "Outlook not so good!",
                "Very doubtful!"
            ];

            int randomNumber = Random.Shared.Next(answers.Count);
            return answers[randomNumber];
        }
    }
}