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

namespace WebRecording
{
    public partial class CodedWorkflow : CodedWorkflowBase
    {
        public CodedWorkflow()
        {
            _ = new System.Type[]{typeof(UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService), typeof(UiPath.Testing.API.ITestingService), typeof(UiPath.Core.Activities.API.ISystemService)};
        }

        protected UiPath.Core.Activities.API.ISystemService system { get => serviceContainer.Resolve<UiPath.Core.Activities.API.ISystemService>(); }

        protected UiPath.Testing.API.ITestingService testing { get => serviceContainer.Resolve<UiPath.Testing.API.ITestingService>(); }

        protected UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService uiAutomation { get => serviceContainer.Resolve<UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService>(); }
    }
}

namespace WebRecording.ObjectRepository
{
    public static class Descriptors
    {
        public static class Chrome__ui_phoria_rec___Yahoo_India_Search_Results
        {
            public static _Implementation._Chrome__ui_phoria_rec___Yahoo_India_Search_Results.__Chrome__ui_phoria_rec___Yahoo_India_Search_Results Chrome__ui_phoria_rec___Yahoo_India_Search_Results { get; private set; } = new _Implementation._Chrome__ui_phoria_rec___Yahoo_India_Search_Results.__Chrome__ui_phoria_rec___Yahoo_India_Search_Results();
        }

        public static class Chrome__UiPhoria
        {
            public static _Implementation._Chrome__UiPhoria.__Chrome__UiPhoria Chrome__UiPhoria { get; private set; } = new _Implementation._Chrome__UiPhoria.__Chrome__UiPhoria();
        }

        public static class Chrome__youtube___Google_Search
        {
            public static _Implementation._Chrome__youtube___Google_Search.__Chrome__youtube___Google_Search Chrome__youtube___Google_Search { get; private set; } = new _Implementation._Chrome__youtube___Google_Search.__Chrome__youtube___Google_Search();
        }

        public static class explorer_exe
        {
            public static _Implementation._explorer_exe.__explorer_exe explorer_exe { get; private set; } = new _Implementation._explorer_exe.__explorer_exe();
        }

        public static class Google_Chrome
        {
            public static _Implementation._Google_Chrome.__Google_Chrome Google_Chrome { get; private set; } = new _Implementation._Google_Chrome.__Google_Chrome();
        }

        public static class New_Tab___Google_Chrome
        {
            public static _Implementation._New_Tab___Google_Chrome.__New_Tab___Google_Chrome New_Tab___Google_Chrome { get; private set; } = new _Implementation._New_Tab___Google_Chrome.__New_Tab___Google_Chrome();
        }
    }
}

namespace WebRecording._Implementation
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

    namespace _Chrome__ui_phoria_rec___Yahoo_India_Search_Results._Chrome__ui_phoria_rec___Yahoo_India_Search_Results
    {
        public class __www_uiphoria_inUiPhoria : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __www_uiphoria_inUiPhoria(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "n1ufM6Z4uE2XBpV4zToluA/3Azghu4I4Um2_eJtTzUvog", DisplayName = "www.uiphoria.inUiPhoria", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome__ui_phoria_rec___Yahoo_India_Search_Results
    {
        public class __Chrome__ui_phoria_rec___Yahoo_India_Search_Results : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Chrome__ui_phoria_rec___Yahoo_India_Search_Results()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "n1ufM6Z4uE2XBpV4zToluA/dauEC7nhiEW2pDsrDp3twQ", DisplayName = "Chrome: ui phoria rec - Yahoo India Search Results", Screen = this};
                www_uiphoria_inUiPhoria = new _Implementation._Chrome__ui_phoria_rec___Yahoo_India_Search_Results._Chrome__ui_phoria_rec___Yahoo_India_Search_Results.__www_uiphoria_inUiPhoria(this, null);
            }

            public _Implementation._Chrome__ui_phoria_rec___Yahoo_India_Search_Results._Chrome__ui_phoria_rec___Yahoo_India_Search_Results.__www_uiphoria_inUiPhoria www_uiphoria_inUiPhoria { get; private set; }
        }
    }

    namespace _Chrome__UiPhoria._Chrome__UiPhoria
    {
        public class ___ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "n1ufM6Z4uE2XBpV4zToluA/BpQ9gKYvFk-LMvZJ0ZEaDQ", DisplayName = "*", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome__UiPhoria._Chrome__UiPhoria
    {
        public class __College_Name : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __College_Name(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "n1ufM6Z4uE2XBpV4zToluA/n0do9lORGU6It5bdafittA", DisplayName = "College Name", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome__UiPhoria._Chrome__UiPhoria
    {
        public class __Department : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Department(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "n1ufM6Z4uE2XBpV4zToluA/L5Ypti3hxUam81OiWzi3EQ", DisplayName = "Department", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome__UiPhoria._Chrome__UiPhoria
    {
        public class __DIV : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __DIV(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "n1ufM6Z4uE2XBpV4zToluA/0uDM29TMVkOyy6OenpJ7ow", DisplayName = "DIV", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome__UiPhoria._Chrome__UiPhoria
    {
        public class __DIV_1_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __DIV_1_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "n1ufM6Z4uE2XBpV4zToluA/05eKKqIzYUS7TxOzyxhFyw", DisplayName = "DIV(1)", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome__UiPhoria._Chrome__UiPhoria
    {
        public class __Mobile_Number : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Mobile_Number(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "n1ufM6Z4uE2XBpV4zToluA/9tx95npM5UmO_NkezbxpJA", DisplayName = "Mobile Number", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome__UiPhoria._Chrome__UiPhoria
    {
        public class __Question : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Question(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "n1ufM6Z4uE2XBpV4zToluA/aX-LI9ugN0-klCFA0h6oAQ", DisplayName = "Question", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome__UiPhoria._Chrome__UiPhoria
    {
        public class __Submit_Here_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Submit_Here_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "n1ufM6Z4uE2XBpV4zToluA/N-4fIZzXZ0OxQT6BsqQQfA", DisplayName = "Submit Here!", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome__UiPhoria._Chrome__UiPhoria
    {
        public class __Weekly_Contest : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Weekly_Contest(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "n1ufM6Z4uE2XBpV4zToluA/x6rRfVbKz0G3S9bNM7pZGg", DisplayName = "Weekly Contest", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome__UiPhoria
    {
        public class __Chrome__UiPhoria : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Chrome__UiPhoria()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "n1ufM6Z4uE2XBpV4zToluA/vgvuU9wvXUq4HDG6gtImGA", DisplayName = "Chrome: UiPhoria", Screen = this};
                _ = new _Implementation._Chrome__UiPhoria._Chrome__UiPhoria.___(this, null);
                College_Name = new _Implementation._Chrome__UiPhoria._Chrome__UiPhoria.__College_Name(this, null);
                Department = new _Implementation._Chrome__UiPhoria._Chrome__UiPhoria.__Department(this, null);
                DIV = new _Implementation._Chrome__UiPhoria._Chrome__UiPhoria.__DIV(this, null);
                DIV_1_ = new _Implementation._Chrome__UiPhoria._Chrome__UiPhoria.__DIV_1_(this, null);
                Mobile_Number = new _Implementation._Chrome__UiPhoria._Chrome__UiPhoria.__Mobile_Number(this, null);
                Question = new _Implementation._Chrome__UiPhoria._Chrome__UiPhoria.__Question(this, null);
                Submit_Here_ = new _Implementation._Chrome__UiPhoria._Chrome__UiPhoria.__Submit_Here_(this, null);
                Weekly_Contest = new _Implementation._Chrome__UiPhoria._Chrome__UiPhoria.__Weekly_Contest(this, null);
            }

            public _Implementation._Chrome__UiPhoria._Chrome__UiPhoria.___ _ { get; private set; }

            public _Implementation._Chrome__UiPhoria._Chrome__UiPhoria.__College_Name College_Name { get; private set; }

            public _Implementation._Chrome__UiPhoria._Chrome__UiPhoria.__Department Department { get; private set; }

            public _Implementation._Chrome__UiPhoria._Chrome__UiPhoria.__DIV DIV { get; private set; }

            public _Implementation._Chrome__UiPhoria._Chrome__UiPhoria.__DIV_1_ DIV_1_ { get; private set; }

            public _Implementation._Chrome__UiPhoria._Chrome__UiPhoria.__Mobile_Number Mobile_Number { get; private set; }

            public _Implementation._Chrome__UiPhoria._Chrome__UiPhoria.__Question Question { get; private set; }

            public _Implementation._Chrome__UiPhoria._Chrome__UiPhoria.__Submit_Here_ Submit_Here_ { get; private set; }

            public _Implementation._Chrome__UiPhoria._Chrome__UiPhoria.__Weekly_Contest Weekly_Contest { get; private set; }
        }
    }

    namespace _Chrome__youtube___Google_Search._Chrome__youtube___Google_Search
    {
        public class __BUTTON : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __BUTTON(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "n1ufM6Z4uE2XBpV4zToluA/GRLb6fjjxkii7fQvv16qsw", DisplayName = "BUTTON", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome__youtube___Google_Search._Chrome__youtube___Google_Search
    {
        public class __Indian_Cars : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Indian_Cars(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "n1ufM6Z4uE2XBpV4zToluA/CwAjW0eSBEer1gXLtirQ9w", DisplayName = "Indian Cars", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome__youtube___Google_Search._Chrome__youtube___Google_Search
    {
        public class __INPUT_search : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __INPUT_search(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "n1ufM6Z4uE2XBpV4zToluA/sUK7QYppj0GkgymIPIPw4Q", DisplayName = "INPUT search", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome__youtube___Google_Search._Chrome__youtube___Google_Search
    {
        public class __POV_When_your : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __POV_When_your(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "n1ufM6Z4uE2XBpV4zToluA/7PbVwcea60SBVv-5v1XYVQ", DisplayName = "POV:When your", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome__youtube___Google_Search._Chrome__youtube___Google_Search
    {
        public class __rajalakshmi_engineering : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __rajalakshmi_engineering(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "n1ufM6Z4uE2XBpV4zToluA/V3z5dCPfuE6c4-gDSbESHQ", DisplayName = "rajalakshmi engineering", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome__youtube___Google_Search._Chrome__youtube___Google_Search
    {
        public class __YouTube__Home : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __YouTube__Home(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "n1ufM6Z4uE2XBpV4zToluA/T-tW2ckFr0aiDHbD_OhSeA", DisplayName = "YouTube: Home", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome__youtube___Google_Search
    {
        public class __Chrome__youtube___Google_Search : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Chrome__youtube___Google_Search()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "n1ufM6Z4uE2XBpV4zToluA/dxzmQU78jU2ptFSSWVNbxA", DisplayName = "Chrome: youtube - Google Search", Screen = this};
                BUTTON = new _Implementation._Chrome__youtube___Google_Search._Chrome__youtube___Google_Search.__BUTTON(this, null);
                Indian_Cars = new _Implementation._Chrome__youtube___Google_Search._Chrome__youtube___Google_Search.__Indian_Cars(this, null);
                INPUT_search = new _Implementation._Chrome__youtube___Google_Search._Chrome__youtube___Google_Search.__INPUT_search(this, null);
                POV_When_your = new _Implementation._Chrome__youtube___Google_Search._Chrome__youtube___Google_Search.__POV_When_your(this, null);
                rajalakshmi_engineering = new _Implementation._Chrome__youtube___Google_Search._Chrome__youtube___Google_Search.__rajalakshmi_engineering(this, null);
                YouTube__Home = new _Implementation._Chrome__youtube___Google_Search._Chrome__youtube___Google_Search.__YouTube__Home(this, null);
            }

            public _Implementation._Chrome__youtube___Google_Search._Chrome__youtube___Google_Search.__BUTTON BUTTON { get; private set; }

            public _Implementation._Chrome__youtube___Google_Search._Chrome__youtube___Google_Search.__Indian_Cars Indian_Cars { get; private set; }

            public _Implementation._Chrome__youtube___Google_Search._Chrome__youtube___Google_Search.__INPUT_search INPUT_search { get; private set; }

            public _Implementation._Chrome__youtube___Google_Search._Chrome__youtube___Google_Search.__POV_When_your POV_When_your { get; private set; }

            public _Implementation._Chrome__youtube___Google_Search._Chrome__youtube___Google_Search.__rajalakshmi_engineering rajalakshmi_engineering { get; private set; }

            public _Implementation._Chrome__youtube___Google_Search._Chrome__youtube___Google_Search.__YouTube__Home YouTube__Home { get; private set; }
        }
    }

    namespace _explorer_exe._explorer_exe
    {
        public class __button_Google_Chrome : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __button_Google_Chrome(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "n1ufM6Z4uE2XBpV4zToluA/ocCNWNNk_0ikLHRvCyG8nw", DisplayName = "button Google Chrome", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _explorer_exe
    {
        public class __explorer_exe : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __explorer_exe()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "n1ufM6Z4uE2XBpV4zToluA/wZNBVDBnTU6KTu43_SycWQ", DisplayName = "explorer.exe", Screen = this};
                button_Google_Chrome = new _Implementation._explorer_exe._explorer_exe.__button_Google_Chrome(this, null);
            }

            public _Implementation._explorer_exe._explorer_exe.__button_Google_Chrome button_Google_Chrome { get; private set; }
        }
    }

    namespace _Google_Chrome._Google_Chrome
    {
        public class __Chrome_Legacy_Window : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Chrome_Legacy_Window(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "n1ufM6Z4uE2XBpV4zToluA/6Qy0O5AVNkKM4yvxIeGBvA", DisplayName = "Chrome Legacy Window", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Google_Chrome
    {
        public class __Google_Chrome : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Google_Chrome()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "n1ufM6Z4uE2XBpV4zToluA/RKbN04Xbv0-s7XK0GjjzNQ", DisplayName = "Google Chrome", Screen = this};
                Chrome_Legacy_Window = new _Implementation._Google_Chrome._Google_Chrome.__Chrome_Legacy_Window(this, null);
            }

            public _Implementation._Google_Chrome._Google_Chrome.__Chrome_Legacy_Window Chrome_Legacy_Window { get; private set; }
        }
    }

    namespace _New_Tab___Google_Chrome._New_Tab___Google_Chrome
    {
        public class __New_Tab___Google_Chrome : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __New_Tab___Google_Chrome(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "n1ufM6Z4uE2XBpV4zToluA/yMZ0JGjTIEuWcIR1hIF-Rw", DisplayName = "New Tab - Google Chrome", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _New_Tab___Google_Chrome
    {
        public class __New_Tab___Google_Chrome : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __New_Tab___Google_Chrome()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "n1ufM6Z4uE2XBpV4zToluA/T9prnx3tPEyUFAiEoKXc7A", DisplayName = "New Tab - Google Chrome", Screen = this};
                New_Tab___Google_Chrome = new _Implementation._New_Tab___Google_Chrome._New_Tab___Google_Chrome.__New_Tab___Google_Chrome(this, null);
            }

            public _Implementation._New_Tab___Google_Chrome._New_Tab___Google_Chrome.__New_Tab___Google_Chrome New_Tab___Google_Chrome { get; private set; }
        }
    }
}