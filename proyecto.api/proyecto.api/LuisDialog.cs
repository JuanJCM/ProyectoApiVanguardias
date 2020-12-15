using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace proyecto.api
{
    public class LuisDialog : ActivityHandler
    {
        private LuisHelper.LuisHelper _luisHelper;
        public LuisDialog(LuisHelper.LuisHelper luisHelper)
        {

        }

        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            var result = await _luisHelper.RecognizerAsync</*el archivo de los comandos de luis*/>(turnContext, cancellationToken);
            var topIntent = result.TopIntent().intent;
            switch (topIntent)
            {
                /*
                 aqui estara todas las opciones que ahorita se ocupan de luis 
                 
                 */
            }
        }
    }
}
