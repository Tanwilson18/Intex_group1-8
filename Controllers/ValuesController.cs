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
            var categories = new[] { "B", "H", "S", "W" };
            int predictionIndex = Array.IndexOf(predict.ToArray(), predict.Max());
            var prediction = new Prediction { PredictedValue = categories[predictionIndex] };//max score different. Get just categorical value

            //Tensor<string> predict = result.First().AsTensor<string>();
            //string predictionValue = predict.ToArray()[0];
            //var prediction = new Prediction { PredictedValue = predictionValue };
            return Ok(prediction);
        }
    }
}
