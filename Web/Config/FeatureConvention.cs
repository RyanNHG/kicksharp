using System;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace Kicksharp.Web.Config
{
    internal class FeatureConvention : IControllerModelConvention
    {
        public void Apply(ControllerModel controller)
        {
            controller.Properties.Add("feature", GetFeatureName(controller.ControllerType));
        }

        private string GetFeatureName(TypeInfo controllerType)
        {
            var namespacePieces = controllerType.Namespace.Split('.');
            string folderName = namespacePieces.Last();
            return folderName;
        }
    }
}