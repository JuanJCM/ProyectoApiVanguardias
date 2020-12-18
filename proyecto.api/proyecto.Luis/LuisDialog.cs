using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Azure.CognitiveServices.Language.LUIS.Authoring;
using Microsoft.Azure.CognitiveServices.Language.LUIS.Runtime;
using Microsoft.Azure.CognitiveServices.Language.LUIS.Runtime.Models;
using Microsoft.Azure.CognitiveServices.Language.LUIS.Authoring.Models;


namespace proyecto.Luis
{
    public class LuisDialog : ActivityHandler
    {
        private readonly Helper.LuisHelper _luisHelper;
        public LuisDialog(Helper.LuisHelper luisHelper)
        {
            _luisHelper = luisHelper;
        }

        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {

            var appId = "a4fe9ae0-be39-4837-b2d9-ed3ca0b33af2";
            var key = "127183aa64af4de893cc822599f2a4ec";
            var predictionResourceName = "luisgroup";

            var predictionEndpoint = $"https://{predictionResourceName}.cognitiveservices.azure.com/";
            var credentials = new Microsoft.Azure.CognitiveServices.Language.LUIS.Authoring.ApiKeyServiceClientCredentials(key);
            var runtimeClient = new LUISRuntimeClient(credentials) { Endpoint = predictionEndpoint };

            var gAppId = new Guid(appId);
            var request = new PredictionRequest { Query = "add tomatoes to rakata1" };
            var predi = await runtimeClient.Prediction.GetSlotPredictionAsync(gAppId, "Production", request);

            var topIntent = predi.Prediction.TopIntent;
            switch (topIntent)
            {
                /*
                 aqui estara todas las opciones que ahorita se ocupan de luis 
                 */
            }
        }

    }
}
