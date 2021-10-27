using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Relizealous.Common
{
    public class CallJavascript
    {
        private readonly IJSRuntime js;

        public CallJavascript(IJSRuntime js)
        {
            this.js = js;
        }

        public async Task PlayAudioFile(string audioFile)
        {
            await js.InvokeVoidAsync("PlayAudioFile", audioFile);
        }
    }
}
