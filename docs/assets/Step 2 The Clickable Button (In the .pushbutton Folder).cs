using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;
using csRevit.API;

namespace csRevit_MyHybridTool
{
    [Transaction(TransactionMode.Manual)]
    public class TriggerServiceCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            // The Button connects to the Interface via the exposed Instance
            IcsRevitBackgroundService myService = MyEnterpriseService.Instance;

            // 1. Ensure it exists and is running
            if (myService == null || myService.CurrentState == ServiceState.Offline)
            {
                message = "The background service is offline. Please restart Revit.";
                return Result.Failed;
            }

            // 2. Prevent Double-Clicking / Thread Crashes
            if (myService.CurrentState == ServiceState.Processing)
            {
                TaskDialog.Show(myService.ServiceName, "Please wait, the service is currently busy processing another task.");
                return Result.Cancelled;
            }

            // 3. Pass the Revit context directly to the Background Service!
            return myService.ExecuteTriggerFromUI(commandData, ref message, elements);
        }
    }
}