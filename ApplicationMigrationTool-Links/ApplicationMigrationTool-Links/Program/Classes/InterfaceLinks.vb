Namespace Program.Classes
    Public Class InterfaceLinks
        Property Raw As String
        Property OldLinks As List(Of InterfaceLink)
        Property DeletedLinks As List(Of InterfaceLink)
        Property NewLinks As List(Of InterfaceLink)

        Public Sub LoadInterfacesList()

        End Sub

        '00 - $Action                                   = Create
        '01 - $SourceLocation                           = Root\PC10\D10\Water
        '02 - $SourceInstanceName                       = FI1004
        '03 - $SourceInstanceTemplateIdentifier         = $AnalogInput
        '04 - $SourceInterfacePath                      = Control
        '05 - $SourceInterfaceIdentifier                = PV
        '06 - $DestinationLocation                      = Root\PC10\D10\Water
        '07 - $DestinationInstanceName                  = FIC1004
        '08 - $DestinationInstanceTemplateIdentifier    = $Ramp
        '09 - $DestinationInterfacePath                 = Control\Logic
        '10 - $DestinationInterfaceIdentifier           = TrackSP
        '11 - $NewDestinationLocation                   = 
        '12 - $NewDestinationInstanceName               = 
        '13 - $NewDestinationInstanceTemplateIdentifier = 
        '14 - $NewDestinationInterfacePath              = 
        '15 - $NewDestinationInterfaceIdentifier        = 
        '16 - $BindingType                              = GraphicalLine / Connector

    End Class
End Namespace