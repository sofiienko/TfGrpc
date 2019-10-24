# $protofiles = Get-ChildItem -path 'tensorflow_serving' -recurse -Include *.proto

# foreach ($item in $protofiles)
# {
#     Write-Output  $item.FullName
# }
 #Remove-Item -recurse 'serving/tensorflow_serving/*' -exclude '*.proto'
 #$protofiles = Get-ChildItem -path 'serving/tensorflow_serving/' -recurse #-Include *.proto
 $script:scriptLocationFolder = Split-Path -Path ($MyInvocation.MyCommand.Path)
 Push-Location  $scriptLocationFolder

 $script:vsixProjectFileXml = New-Object System.Xml.XmlDocument
 $script:vsixProjectFileXml.Load("C:\Users\Anton.Sofienko.GAMANET\source\repos\TfGrpc\TfGrpc\TfGrpc.csproj")

 $itemGroup =  $script:vsixProjectFileXml.Project.ItemGroup


 $protofiles = Get-ChildItem -path 'C:\Users\Anton.Sofienko.GAMANET\source\repos\tensorflow\tensorflow\compiler' -recurse -Include *.proto


foreach ($item in $protofiles)
{
    Write-Output  $item.FullName

    $protobuf =$script:vsixProjectFileXml.CreateElement("Protobuf",$xmlDocument.DocumentElement.NamespaceURI)
    $protobuf.SetAttribute("Include", $item.FullName)
    $protobuf.SetAttribute("GrpcServices","Client")

    $itemGroup.AppendChild($protobuf)

}
$script:vsixProjectFileXml.Save("C:\Users\Anton.Sofienko.GAMANET\source\repos\TfGrpc\TfGrpc\TfGrpc5.csproj")


