// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;workbook&quot; object.</para>
    ///     <para type="description">GET ~/me/drives/{driveId}/list/drive/root/workbook</para>
    ///     <para type="description">Retrieves the &quot;workbook&quot; object (which is of type &quot;microsoft.graph.workbook&quot;).</para>
    /// </summary>
    [Cmdlet("Get", "Me_Drives_List_Drive_Root_Workbook", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.workbook")]
    [ResourceReference]
    public class Get_Me_Drives_List_Drive_Root_Workbook : GetCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;application&quot; property, of type &quot;microsoft.graph.workbookApplication&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookApplication")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object application { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;names&quot; property, of type &quot;microsoft.graph.workbookNamedItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookNamedItem")]
        [Selectable]
        [Expandable]
        public System.Object[] names { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;tables&quot; property, of type &quot;microsoft.graph.workbookTable&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookTable")]
        [Selectable]
        [Expandable]
        public System.Object[] tables { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;worksheets&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookWorksheet")]
        [Selectable]
        [Expandable]
        public System.Object[] worksheets { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;functions&quot; property, of type &quot;microsoft.graph.workbookFunctions&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookFunctions")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object functions { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/list/drive/root/workbook";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.workbook&quot; object.</para>
    ///     <para type="description">POST ~/me/drives/{driveId}/list/drive/root/workbook</para>
    ///     <para type="description">Creates the &quot;workbook&quot; object (which is of type &quot;microsoft.graph.workbook&quot;).</para>
    /// </summary>
    [Cmdlet("New", "Me_Drives_List_Drive_Root_Workbook", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.workbook")]
    [ODataType("microsoft.graph.workbook")]
    [ResourceReference]
    public class New_Me_Drives_List_Drive_Root_Workbook : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;application&quot; property, of type &quot;microsoft.graph.workbookApplication&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookApplication")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbook", HelpMessage = @"The &quot;application&quot; property, of type &quot;microsoft.graph.workbookApplication&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;application&quot; property, of type &quot;microsoft.graph.workbookApplication&quot;.")]
        public System.Object application { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;names&quot; property, of type &quot;microsoft.graph.workbookNamedItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookNamedItem")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbook", HelpMessage = @"The &quot;names&quot; property, of type &quot;microsoft.graph.workbookNamedItem&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;names&quot; property, of type &quot;microsoft.graph.workbookNamedItem&quot;.")]
        public System.Object[] names { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;tables&quot; property, of type &quot;microsoft.graph.workbookTable&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookTable")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbook", HelpMessage = @"The &quot;tables&quot; property, of type &quot;microsoft.graph.workbookTable&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;tables&quot; property, of type &quot;microsoft.graph.workbookTable&quot;.")]
        public System.Object[] tables { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;worksheets&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookWorksheet")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbook", HelpMessage = @"The &quot;worksheets&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;worksheets&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.")]
        public System.Object[] worksheets { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;functions&quot; property, of type &quot;microsoft.graph.workbookFunctions&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookFunctions")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbook", HelpMessage = @"The &quot;functions&quot; property, of type &quot;microsoft.graph.workbookFunctions&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;functions&quot; property, of type &quot;microsoft.graph.workbookFunctions&quot;.")]
        public System.Object functions { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/list/drive/root/workbook";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.workbook&quot;.</para>
    ///     <para type="description">PATCH ~/me/drives/{driveId}/list/drive/root/workbook</para>
    ///     <para type="description">Updates the &quot;workbook&quot; object (which is of type &quot;microsoft.graph.workbook&quot;).</para>
    /// </summary>
    [Cmdlet("Update", "Me_Drives_List_Drive_Root_Workbook", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.workbook")]
    [ODataType("microsoft.graph.workbook")]
    public class Update_Me_Drives_List_Drive_Root_Workbook : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;application&quot; property, of type &quot;microsoft.graph.workbookApplication&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookApplication")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbook", HelpMessage = @"The &quot;application&quot; property, of type &quot;microsoft.graph.workbookApplication&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;application&quot; property, of type &quot;microsoft.graph.workbookApplication&quot;.")]
        public System.Object application { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;names&quot; property, of type &quot;microsoft.graph.workbookNamedItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookNamedItem")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbook", HelpMessage = @"The &quot;names&quot; property, of type &quot;microsoft.graph.workbookNamedItem&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;names&quot; property, of type &quot;microsoft.graph.workbookNamedItem&quot;.")]
        public System.Object[] names { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;tables&quot; property, of type &quot;microsoft.graph.workbookTable&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookTable")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbook", HelpMessage = @"The &quot;tables&quot; property, of type &quot;microsoft.graph.workbookTable&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;tables&quot; property, of type &quot;microsoft.graph.workbookTable&quot;.")]
        public System.Object[] tables { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;worksheets&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookWorksheet")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbook", HelpMessage = @"The &quot;worksheets&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;worksheets&quot; property, of type &quot;microsoft.graph.workbookWorksheet&quot;.")]
        public System.Object[] worksheets { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;functions&quot; property, of type &quot;microsoft.graph.workbookFunctions&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbook&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookFunctions")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.workbook", HelpMessage = @"The &quot;functions&quot; property, of type &quot;microsoft.graph.workbookFunctions&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;functions&quot; property, of type &quot;microsoft.graph.workbookFunctions&quot;.")]
        public System.Object functions { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/list/drive/root/workbook";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.workbook&quot; object.</para>
    ///     <para type="description">DELETE ~/me/drives/{driveId}/list/drive/root/workbook</para>
    ///     <para type="description">Removes the &quot;workbook&quot; object (which is of type &quot;microsoft.graph.workbook&quot;).</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Drives_List_Drive_Root_Workbook", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbook")]
    public class Remove_Me_Drives_List_Drive_Root_Workbook : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/list/drive/root/workbook";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drives/{driveId}/list/drive/root/workbook/createSession</para>
    ///     <para type="description">The action &quot;microsoft.graph.createSession&quot;, which exists on the type &quot;microsoft.graph.workbook&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookSessionInfo&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drives_List_Drive_Root_Workbook_CreateSession", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbook")]
    public class Invoke_Me_Drives_List_Drive_Root_Workbook_CreateSession : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;persistChanges&quot; parameter, which is accepted by the &quot;microsoft.graph.createSession&quot; action.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;persistChanges&quot; parameter, which is accepted by the &quot;microsoft.graph.createSession&quot; action.")]
        public System.Boolean persistChanges { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/list/drive/root/workbook/createSession";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drives/{driveId}/list/drive/root/workbook/closeSession</para>
    ///     <para type="description">The action &quot;microsoft.graph.closeSession&quot;, which exists on the type &quot;microsoft.graph.workbook&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drives_List_Drive_Root_Workbook_CloseSession", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbook")]
    public class Invoke_Me_Drives_List_Drive_Root_Workbook_CloseSession : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/list/drive/root/workbook/closeSession";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drives/{driveId}/list/drive/root/workbook/refreshSession</para>
    ///     <para type="description">The action &quot;microsoft.graph.refreshSession&quot;, which exists on the type &quot;microsoft.graph.workbook&quot;.</para>
    ///     <para type="description">This action does not return any objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drives_List_Drive_Root_Workbook_RefreshSession", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbook")]
    public class Invoke_Me_Drives_List_Drive_Root_Workbook_RefreshSession : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/list/drive/root/workbook/refreshSession";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drives/{driveId}/list/drive/root/workbook/processQuery</para>
    ///     <para type="description">The action &quot;microsoft.graph.processQuery&quot;, which exists on the type &quot;microsoft.graph.workbook&quot;.</para>
    ///     <para type="description">This action returns a &quot;Edm.Stream&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drives_List_Drive_Root_Workbook_ProcessQuery", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbook")]
    public class Invoke_Me_Drives_List_Drive_Root_Workbook_ProcessQuery : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;input&quot; parameter, which is accepted by the &quot;microsoft.graph.processQuery&quot; action.</para>
        /// </summary>
        [ODataType("Edm.Stream")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;input&quot; parameter, which is accepted by the &quot;microsoft.graph.processQuery&quot; action.")]
        public System.IO.Stream input { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/list/drive/root/workbook/processQuery";
        }
    }
}