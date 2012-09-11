﻿// ﻿Copyright (c) Pavel Bakshy, Valeriy Ogiy. All rights reserved. See License.txt in the project root for license information.

using System;

using OpenQA.Selenium;

namespace Selenol.Elements
{
    /// <summary>The option element.</summary>
    public class OptionElement
    {
        private readonly IWebElement webElement;

        /// <summary>Initializes a new instance of the <see cref="OptionElement"/> class.</summary>
        /// <param name="webElement">The web element.</param>
        public OptionElement(IWebElement webElement)
        {
            this.webElement = webElement;
        }

        /// <summary>Gets the option text.</summary>
        public string Text
        {
            get
            {
                return this.webElement.Text;
            }
        }

        /// <summary>Gets the option value.</summary>
        public string Value
        {
            get
            {
                return this.webElement.GetAttribute(HtmlElementAttributes.Value);
            }
        }

        /// <summary>Gets a value indicating whether the option is selected or not.</summary>
        public bool IsSelected
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>Gets a value indicating whether the option is disabled or not.</summary>
        public bool IsDisabled
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>Select the option.</summary>
        /// <returns>The same option.</returns>
        public OptionElement Select()
        {
            throw new NotImplementedException();
        }
    }
}