<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.BtnTestTAServer = New System.Windows.Forms.Button()
		Me.BtnExit = New System.Windows.Forms.Button()
		Me.BtnAddAccount = New System.Windows.Forms.Button()
		Me.BtnAddTrigger = New System.Windows.Forms.Button()
		Me.BtnListAccounts = New System.Windows.Forms.Button()
		Me.BtnListTriggers = New System.Windows.Forms.Button()
		Me.ListActions = New System.Windows.Forms.ListBox()
		Me.ListTriggers = New System.Windows.Forms.ListBox()
		Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
		Me.ListAccounts = New System.Windows.Forms.ListBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'BtnTestTAServer
		'
		Me.BtnTestTAServer.ForeColor = System.Drawing.SystemColors.Highlight
		Me.BtnTestTAServer.Location = New System.Drawing.Point(220, 545)
		Me.BtnTestTAServer.Margin = New System.Windows.Forms.Padding(2)
		Me.BtnTestTAServer.Name = "BtnTestTAServer"
		Me.BtnTestTAServer.Size = New System.Drawing.Size(82, 27)
		Me.BtnTestTAServer.TabIndex = 0
		Me.BtnTestTAServer.Text = "Test TA Server"
		Me.BtnTestTAServer.UseVisualStyleBackColor = True
		'
		'BtnExit
		'
		Me.BtnExit.ForeColor = System.Drawing.SystemColors.Highlight
		Me.BtnExit.Location = New System.Drawing.Point(332, 543)
		Me.BtnExit.Margin = New System.Windows.Forms.Padding(2)
		Me.BtnExit.Name = "BtnExit"
		Me.BtnExit.Size = New System.Drawing.Size(82, 29)
		Me.BtnExit.TabIndex = 1
		Me.BtnExit.Text = "Exit"
		Me.BtnExit.UseVisualStyleBackColor = True
		'
		'BtnAddAccount
		'
		Me.BtnAddAccount.ForeColor = System.Drawing.SystemColors.Highlight
		Me.BtnAddAccount.Location = New System.Drawing.Point(332, 497)
		Me.BtnAddAccount.Margin = New System.Windows.Forms.Padding(2)
		Me.BtnAddAccount.Name = "BtnAddAccount"
		Me.BtnAddAccount.Size = New System.Drawing.Size(82, 27)
		Me.BtnAddAccount.TabIndex = 2
		Me.BtnAddAccount.Text = "Add Account"
		Me.BtnAddAccount.UseVisualStyleBackColor = True
		'
		'BtnAddTrigger
		'
		Me.BtnAddTrigger.ForeColor = System.Drawing.SystemColors.Highlight
		Me.BtnAddTrigger.Location = New System.Drawing.Point(437, 497)
		Me.BtnAddTrigger.Margin = New System.Windows.Forms.Padding(2)
		Me.BtnAddTrigger.Name = "BtnAddTrigger"
		Me.BtnAddTrigger.Size = New System.Drawing.Size(82, 27)
		Me.BtnAddTrigger.TabIndex = 3
		Me.BtnAddTrigger.Text = "Add Trigger"
		Me.BtnAddTrigger.UseVisualStyleBackColor = True
		'
		'BtnListAccounts
		'
		Me.BtnListAccounts.ForeColor = System.Drawing.SystemColors.Highlight
		Me.BtnListAccounts.Location = New System.Drawing.Point(15, 497)
		Me.BtnListAccounts.Margin = New System.Windows.Forms.Padding(2)
		Me.BtnListAccounts.Name = "BtnListAccounts"
		Me.BtnListAccounts.Size = New System.Drawing.Size(82, 27)
		Me.BtnListAccounts.TabIndex = 4
		Me.BtnListAccounts.Text = "List Accounts"
		Me.BtnListAccounts.UseVisualStyleBackColor = True
		'
		'BtnListTriggers
		'
		Me.BtnListTriggers.ForeColor = System.Drawing.SystemColors.Highlight
		Me.BtnListTriggers.Location = New System.Drawing.Point(120, 497)
		Me.BtnListTriggers.Margin = New System.Windows.Forms.Padding(2)
		Me.BtnListTriggers.Name = "BtnListTriggers"
		Me.BtnListTriggers.Size = New System.Drawing.Size(82, 27)
		Me.BtnListTriggers.TabIndex = 5
		Me.BtnListTriggers.Text = "List Triggers"
		Me.BtnListTriggers.UseVisualStyleBackColor = True
		'
		'ListActions
		'
		Me.ListActions.ForeColor = System.Drawing.SystemColors.Highlight
		Me.ListActions.FormattingEnabled = True
		Me.ListActions.Location = New System.Drawing.Point(16, 263)
		Me.ListActions.Margin = New System.Windows.Forms.Padding(2)
		Me.ListActions.Name = "ListActions"
		Me.ListActions.Size = New System.Drawing.Size(581, 95)
		Me.ListActions.TabIndex = 6
		'
		'ListTriggers
		'
		Me.ListTriggers.ForeColor = System.Drawing.SystemColors.Highlight
		Me.ListTriggers.FormattingEnabled = True
		Me.ListTriggers.Location = New System.Drawing.Point(17, 147)
		Me.ListTriggers.Margin = New System.Windows.Forms.Padding(2)
		Me.ListTriggers.Name = "ListTriggers"
		Me.ListTriggers.Size = New System.Drawing.Size(580, 108)
		Me.ListTriggers.TabIndex = 7
		'
		'WebBrowser1
		'
		Me.WebBrowser1.Location = New System.Drawing.Point(15, 366)
		Me.WebBrowser1.Margin = New System.Windows.Forms.Padding(2)
		Me.WebBrowser1.MinimumSize = New System.Drawing.Size(11, 11)
		Me.WebBrowser1.Name = "WebBrowser1"
		Me.WebBrowser1.Size = New System.Drawing.Size(580, 110)
		Me.WebBrowser1.TabIndex = 8
		'
		'ListAccounts
		'
		Me.ListAccounts.ForeColor = System.Drawing.SystemColors.Highlight
		Me.ListAccounts.FormattingEnabled = True
		Me.ListAccounts.Location = New System.Drawing.Point(20, 30)
		Me.ListAccounts.Margin = New System.Windows.Forms.Padding(2)
		Me.ListAccounts.Name = "ListAccounts"
		Me.ListAccounts.Size = New System.Drawing.Size(577, 95)
		Me.ListAccounts.TabIndex = 9
		'
		'Button1
		'
		Me.Button1.ForeColor = System.Drawing.SystemColors.Highlight
		Me.Button1.Location = New System.Drawing.Point(548, 497)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(81, 27)
		Me.Button1.TabIndex = 10
		Me.Button1.Text = "Add Action"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.ForeColor = System.Drawing.SystemColors.Highlight
		Me.Button2.Location = New System.Drawing.Point(220, 497)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(82, 27)
		Me.Button2.TabIndex = 11
		Me.Button2.Text = "List Actions"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(661, 591)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.ListAccounts)
		Me.Controls.Add(Me.WebBrowser1)
		Me.Controls.Add(Me.ListTriggers)
		Me.Controls.Add(Me.ListActions)
		Me.Controls.Add(Me.BtnListTriggers)
		Me.Controls.Add(Me.BtnListAccounts)
		Me.Controls.Add(Me.BtnAddTrigger)
		Me.Controls.Add(Me.BtnAddAccount)
		Me.Controls.Add(Me.BtnExit)
		Me.Controls.Add(Me.BtnTestTAServer)
		Me.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "Form1"
		Me.Text = "ThinkAutomationReports"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents BtnTestTAServer As Button
	Friend WithEvents BtnExit As Button
	Friend WithEvents BtnAddAccount As Button
	Friend WithEvents BtnAddTrigger As Button
	Friend WithEvents BtnListAccounts As Button
	Friend WithEvents BtnListTriggers As Button
	Friend WithEvents ListActions As ListBox
	Friend WithEvents ListTriggers As ListBox
	Friend WithEvents WebBrowser1 As WebBrowser
	Friend WithEvents ListAccounts As ListBox
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
End Class
