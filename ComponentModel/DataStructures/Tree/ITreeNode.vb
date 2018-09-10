﻿#Region "Microsoft.VisualBasic::4ffa31b8fb1c7d5ab245f4495012ba7d, Microsoft.VisualBasic.Core\ComponentModel\DataStructures\Tree\ITreeNode.vb"

    ' Author:
    ' 
    '       asuka (amethyst.asuka@gcmodeller.org)
    '       xie (genetics@smrucc.org)
    '       xieguigang (xie.guigang@live.com)
    ' 
    ' Copyright (c) 2018 GPL3 Licensed
    ' 
    ' 
    ' GNU GENERAL PUBLIC LICENSE (GPL3)
    ' 
    ' 
    ' This program is free software: you can redistribute it and/or modify
    ' it under the terms of the GNU General Public License as published by
    ' the Free Software Foundation, either version 3 of the License, or
    ' (at your option) any later version.
    ' 
    ' This program is distributed in the hope that it will be useful,
    ' but WITHOUT ANY WARRANTY; without even the implied warranty of
    ' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    ' GNU General Public License for more details.
    ' 
    ' You should have received a copy of the GNU General Public License
    ' along with this program. If not, see <http://www.gnu.org/licenses/>.



    ' /********************************************************************************/

    ' Summaries:

    '     Interface ITreeNode
    ' 
    '         Properties: ChildNodes, FullyQualifiedName, IsLeaf, IsRoot, Parent
    ' 
    '         Function: GetRootNode, IteratesAllChilds
    ' 
    '         Sub: ChildCountsTravel
    ' 
    ' 
    ' /********************************************************************************/

#End Region

Namespace ComponentModel.DataStructures.Tree

    Public Interface ITreeNode(Of T)

        Property Parent() As T
        ''' <summary>
        ''' Children
        ''' </summary>
        Property ChildNodes() As List(Of T)

        ReadOnly Property FullyQualifiedName() As String
        ReadOnly Property IsLeaf() As Boolean
        ReadOnly Property IsRoot() As Boolean

        Function GetRootNode() As T
        Function IteratesAllChilds() As IEnumerable(Of T)
        Sub ChildCountsTravel(distribute As Dictionary(Of String, Double), Optional getID As Func(Of T, String) = Nothing)

    End Interface
End Namespace
