﻿using Microsoft.AspNetCore.Components;

namespace AntDesign
{
    public partial class AntTabPane : AntDomComponentBase
    {
        private const string PrefixCls = "ant-tabs-tab";
        private AntTabs _parent;

        internal ClassMapper _classMapper = new ClassMapper();

        internal bool IsActive { get; set; }

        public AntTabPane()
        {
        }

        public AntTabPane(string key, RenderFragment tab, RenderFragment childContent)
        {
            this.Key = key;
            this.Tab = tab;
            this.ChildContent = childContent;
        }

        [CascadingParameter]
        internal AntTabs Parent
        {
            get
            {
                return _parent;
            }
            set
            {
                if (_parent == null)
                {
                    _parent = value;
                    _parent.AddTabPane(this);
                }
            }
        }

        /// <summary>
        /// Forced render of content in tabs, not lazy render after clicking on tabs
        /// </summary>
        [Parameter]
        public bool ForceRender { get; set; } = false;

        /// <summary>
        /// TabPane's key
        /// </summary>
        [Parameter]
        public string Key { get; set; }

        /// <summary>
        /// Show text in <see cref="AntTabPane"/>'s head
        /// </summary>
        [Parameter]
        public RenderFragment Tab { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public bool Disabled { get; set; }

        [Parameter]
        public bool Closable { get; set; } = true;

        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            _classMapper.Clear().
                Add(PrefixCls)
                .If($"{PrefixCls}-active", () => IsActive)
                .If($"{PrefixCls}-disabled", () => Disabled);
        }
    }
}
