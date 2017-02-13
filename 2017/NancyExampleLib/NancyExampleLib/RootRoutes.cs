using Nancy;


namespace NancyExampleLib
{
    public class RootRoutes : NancyModule
    {
        public RootRoutes()
        {
            Get["/"] = parameters =>
            {
                return "Hello World";
            };

            Get["jsontest"] = parameters =>
            {
                var test = new
                {
                    Name = "Peter Shaw",
                    Twitter = "shawty_ds",
                    Occupation = "Software Developer"
                };

                return Response.AsJson(test);
            };
        }
    }
}
