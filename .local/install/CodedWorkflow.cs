using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.GSuite.Activities.Api;
using UiPath.Orchestrator.Client.Models;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;
using UiPath.CodedWorkflows.DescriptorIntegration;

namespace DHStockUpdates
{
    public partial class CodedWorkflow : CodedWorkflowBase
    {
        public CodedWorkflow()
        {
            _ = new System.Type[]{typeof(UiPath.GSuite.Activities.Api.IGoogleConnectionsService), typeof(UiPath.Core.Activities.API.ISystemService), typeof(UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService)};
        }

        protected UiPath.GSuite.Activities.Api.IGoogleConnectionsService google { get => serviceContainer.Resolve<UiPath.GSuite.Activities.Api.IGoogleConnectionsService>(); }

        protected UiPath.Core.Activities.API.ISystemService system { get => serviceContainer.Resolve<UiPath.Core.Activities.API.ISystemService>(); }

        protected UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService uiAutomation { get => serviceContainer.Resolve<UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService>(); }
    }
}

namespace DHStockUpdates.ObjectRepository
{
    public static class Descriptors
    {
    }
}

namespace DHStockUpdates._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }

        public IElementDescriptor ParentElement { get; set; }

        public IElementDescriptor Element { get; set; }
    }
}