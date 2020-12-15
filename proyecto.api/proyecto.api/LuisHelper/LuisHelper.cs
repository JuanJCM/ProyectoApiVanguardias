using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.AI.Luis;
using Microsoft.Bot.Configuration;

namespace proyecto.api.LuisHelper
{
    public class LuisHelper : IRecognizer
    {
        private readonly LuisRecognizer _luisRecognizer;
        public LuisHelper()
        {
            var service = new LuisService()
            {
                AppId = "a4fe9ae0-be39-4837-b2d9-ed3ca0b33af2",
                SubscriptionKey = "127183aa64af4de893cc822599f2a4ec",
                Region = "eastus",
                Version = "0.1"
            };

            var app = new LuisApplication(service);
            var regOptions = new LuisRecognizerOptionsV2(app)
            {
                IncludeAPIResults = true,
                PredictionOptions = new LuisPredictionOptions()
                {
                    IncludeAllIntents =true,
                    IncludeInstanceData = true
                }
            };
            _luisRecognizer = new LuisRecognizer(regOptions);
        }

        async Task<RecognizerResult> IRecognizer.RecognizeAsync(ITurnContext turnContext, CancellationToken cancellationToken)
        {
            return await _luisRecognizer.RecognizeAsync(turnContext, cancellationToken);
        }

        async Task<T> IRecognizer.RecognizeAsync<T>(ITurnContext turnContext, CancellationToken cancellationToken)
        {
            return await _luisRecognizer.RecognizeAsync<T>(turnContext, cancellationToken);
        }
    }
}
