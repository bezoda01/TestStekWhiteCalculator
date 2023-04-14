﻿using TestStack.White.UIItems;

namespace Framework.Elements
{
    public class WFTextView : BaseElement
    {
        public WFTextView(IUIItem uiitem, string elementName) : base(uiitem, elementName)
        {
        }

        public WFTextView(IUIItem[] uiitems, string elementName) : base(uiitems, elementName)
        {
        }
    }
}