using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;
using UiPath.CodedWorkflows.DescriptorIntegration;

namespace assignment2_movie
{
    public partial class CodedWorkflow : CodedWorkflowBase
    {
        public CodedWorkflow()
        {
            _ = new System.Type[]{typeof(UiPath.Testing.API.ITestingService), typeof(UiPath.Core.Activities.API.ISystemService), typeof(UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService)};
        }

        protected UiPath.Core.Activities.API.ISystemService system { get => serviceContainer.Resolve<UiPath.Core.Activities.API.ISystemService>(); }

        protected UiPath.Testing.API.ITestingService testing { get => serviceContainer.Resolve<UiPath.Testing.API.ITestingService>(); }

        protected UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService uiAutomation { get => serviceContainer.Resolve<UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService>(); }
    }
}

namespace assignment2_movie.ObjectRepository
{
    public static class Descriptors
    {
        public static class Chrome__IMDb__Ratings__Reviews__and_Where_to_Watch_the_Best_Movies___TV_Shows
        {
            public static _Implementation._Chrome__IMDb__Ratings__Reviews__and_Where_to_Watch_the_Best_Movies___TV_Shows.__Chrome__IMDb__Ratings__Reviews__and_Where_to_Watch_the_Best_Movies___TV_Shows Chrome__IMDb__Ratings__Reviews__and_Where_to_Watch_the_Best_Movies___TV_Shows { get; private set; } = new _Implementation._Chrome__IMDb__Ratings__Reviews__and_Where_to_Watch_the_Best_Movies___TV_Shows.__Chrome__IMDb__Ratings__Reviews__and_Where_to_Watch_the_Best_Movies___TV_Shows();
        }

        public static class Chrome__New_Tab___Google_Chrome
        {
            public static _Implementation._Chrome__New_Tab___Google_Chrome.__Chrome__New_Tab___Google_Chrome Chrome__New_Tab___Google_Chrome { get; private set; } = new _Implementation._Chrome__New_Tab___Google_Chrome.__Chrome__New_Tab___Google_Chrome();
        }
    }
}

namespace assignment2_movie._Implementation
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

    namespace _Chrome__IMDb__Ratings__Reviews__and_Where_to_Watch_the_Best_Movies___TV_Shows._Chrome__IMDb__Ratings__Reviews__and_Where_to_Watch_the_Best_Movies___TV_Shows
    {
        public class __All : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __All(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "5gW-Z8rpfEm09WdpeomG2w/9Vm-ZpyYLUmSmNuGkdd3Pw", DisplayName = "All", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome__IMDb__Ratings__Reviews__and_Where_to_Watch_the_Best_Movies___TV_Shows._Chrome__IMDb__Ratings__Reviews__and_Where_to_Watch_the_Best_Movies___TV_Shows
    {
        public class __Jailer2023Not_Rated2h : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Jailer2023Not_Rated2h(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "5gW-Z8rpfEm09WdpeomG2w/aQ9MLFOE2UOAhJhSqK4hcQ", DisplayName = "Jailer2023Not Rated2h", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome__IMDb__Ratings__Reviews__and_Where_to_Watch_the_Best_Movies___TV_Shows._Chrome__IMDb__Ratings__Reviews__and_Where_to_Watch_the_Best_Movies___TV_Shows
    {
        public class __Jailer2023Rajinikanth___ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Jailer2023Rajinikanth___(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "5gW-Z8rpfEm09WdpeomG2w/Q4laHj5UcE28pdNklxzR8g", DisplayName = "Jailer2023Rajinikanth, …", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome__IMDb__Ratings__Reviews__and_Where_to_Watch_the_Best_Movies___TV_Shows
    {
        public class __Chrome__IMDb__Ratings__Reviews__and_Where_to_Watch_the_Best_Movies___TV_Shows : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Chrome__IMDb__Ratings__Reviews__and_Where_to_Watch_the_Best_Movies___TV_Shows()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "5gW-Z8rpfEm09WdpeomG2w/u-36N0splEKZvrjRnQRJlQ", DisplayName = "Chrome: IMDb: Ratings, Reviews, and Where to Watch the Best Movies & TV Shows", Screen = this};
                All = new _Implementation._Chrome__IMDb__Ratings__Reviews__and_Where_to_Watch_the_Best_Movies___TV_Shows._Chrome__IMDb__Ratings__Reviews__and_Where_to_Watch_the_Best_Movies___TV_Shows.__All(this, null);
                Jailer2023Not_Rated2h = new _Implementation._Chrome__IMDb__Ratings__Reviews__and_Where_to_Watch_the_Best_Movies___TV_Shows._Chrome__IMDb__Ratings__Reviews__and_Where_to_Watch_the_Best_Movies___TV_Shows.__Jailer2023Not_Rated2h(this, null);
                Jailer2023Rajinikanth___ = new _Implementation._Chrome__IMDb__Ratings__Reviews__and_Where_to_Watch_the_Best_Movies___TV_Shows._Chrome__IMDb__Ratings__Reviews__and_Where_to_Watch_the_Best_Movies___TV_Shows.__Jailer2023Rajinikanth___(this, null);
            }

            public _Implementation._Chrome__IMDb__Ratings__Reviews__and_Where_to_Watch_the_Best_Movies___TV_Shows._Chrome__IMDb__Ratings__Reviews__and_Where_to_Watch_the_Best_Movies___TV_Shows.__All All { get; private set; }

            public _Implementation._Chrome__IMDb__Ratings__Reviews__and_Where_to_Watch_the_Best_Movies___TV_Shows._Chrome__IMDb__Ratings__Reviews__and_Where_to_Watch_the_Best_Movies___TV_Shows.__Jailer2023Not_Rated2h Jailer2023Not_Rated2h { get; private set; }

            public _Implementation._Chrome__IMDb__Ratings__Reviews__and_Where_to_Watch_the_Best_Movies___TV_Shows._Chrome__IMDb__Ratings__Reviews__and_Where_to_Watch_the_Best_Movies___TV_Shows.__Jailer2023Rajinikanth___ Jailer2023Rajinikanth___ { get; private set; }
        }
    }

    namespace _Chrome__New_Tab___Google_Chrome._Chrome__New_Tab___Google_Chrome
    {
        public class __https___www_imdb_com_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __https___www_imdb_com_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "5gW-Z8rpfEm09WdpeomG2w/GNDAoTjNqEWot1kLayLA5g", DisplayName = "https://www.imdb.com/", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome__New_Tab___Google_Chrome
    {
        public class __Chrome__New_Tab___Google_Chrome : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Chrome__New_Tab___Google_Chrome()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "5gW-Z8rpfEm09WdpeomG2w/JK45LRBDlECwrv6RzO2Seg", DisplayName = "Chrome: New Tab - Google Chrome", Screen = this};
                https___www_imdb_com_ = new _Implementation._Chrome__New_Tab___Google_Chrome._Chrome__New_Tab___Google_Chrome.__https___www_imdb_com_(this, null);
            }

            public _Implementation._Chrome__New_Tab___Google_Chrome._Chrome__New_Tab___Google_Chrome.__https___www_imdb_com_ https___www_imdb_com_ { get; private set; }
        }
    }
}