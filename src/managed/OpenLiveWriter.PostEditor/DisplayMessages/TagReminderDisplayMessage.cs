// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for details.

using System;
using System.ComponentModel;
using OpenLiveWriter.Controls;

namespace OpenLiveWriter.PostEditor.DisplayMessages
{

	public class TagReminderDisplayMessage : DisplayMessage
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public TagReminderDisplayMessage(IContainer container)
		{
			///
			/// Required for Windows.Forms Class Composition Designer support
			///
			container.Add(this);
			InitializeComponent();

		}

		public TagReminderDisplayMessage()
		{
			///
			/// Required for Windows.Forms Class Composition Designer support
			///
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			//
			// ConfirmDeleteEntryDisplayMessage
			//
			this.Buttons = System.Windows.Forms.MessageBoxButtons.YesNo;
			this.DefaultButton = System.Windows.Forms.MessageBoxDefaultButton.Button2 ;
			this.Text = "You have not added tags to this post.{0}Do you still want to continue with publishing?";
			this.Title = "Tagging Reminder";
			this.Type = DisplayMessageType.Question;

		}
		#endregion
	}
}
