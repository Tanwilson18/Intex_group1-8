using Intex_group1_8.Models.ModelApi;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;
using System.Linq;

namespace Intex_group1_8.Controllers
{
    [ApiController]
    [Route("/predict")]

    public class ValuesController : ControllerBase
    {
        private InferenceSession _session;

        public ValuesController(InferenceSession session)
        {
            _session = session;
        }

        [HttpPost]
        public ActionResult Score(Models.ModelApi.MummyData data)
        {
            var result = _session.Run(new List<NamedOnnxValue>
            {
                NamedOnnxValue.CreateFromTensor("float_input", data.AsTensor())
            });
            Tensor<string> predict = result.First().AsTensor<string>();
            var categories = new[] { "H", "S", "W", "B" };
            int predictionIndex = Array.IndexOf(predict.ToArray(), predict.Max());
            var prediction = new Prediction { PredictedValue = categories[predictionIndex] };//max score different. Get just categorical value
            return Ok(prediction);
        }
    }
}
