using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using csRevit.API;

namespace csRevit_MyHybridTool
{
    public class MyEnterpriseService : IExternalApplication, IcsRevitBackgroundService
    {
        // 1. Expose a static instance so the UI Button can find this service!
        public static MyEnterpriseService Instance { get; private set; }

        // 2. Implement the IcsRevitBackgroundService Contract
        public string ServiceName => "Enterprise Door Updater";
        public string Version => "1.0.0";
        public ServiceState CurrentState { get; private set; } = ServiceState.Offline;

        public Result OnStartup(UIControlledApplication app)
        {
            Instance = this;
            CurrentState = ServiceState.Idle; // Mark as ready
            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication app)
        {
            CurrentState = ServiceState.Offline;
            return Result.Succeeded;
        }

        // 3. The Execution Payload triggered by the UI Button
        public Result ExecuteTriggerFromUI(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            CurrentState = ServiceState.Processing; // Lock the service so it isn't triggered twice
            
            try
            {
                Document doc = commandData.Application.ActiveUIDocument.Document;
                TaskDialog.Show(ServiceName, "The UI Button successfully triggered the Background Service!");
                
                return Result.Succeeded;
            }
            catch (System.Exception ex)
            {
                message = ex.Message;
                return Result.Failed;
            }
            finally
            {
                CurrentState = ServiceState.Idle; // Unlock the service
            }
        }
    }
}