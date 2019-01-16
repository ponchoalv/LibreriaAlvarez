// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API

function saveAsFile(filename, bytesBase64) {
    var link = document.createElement('a');
    link.download = filename;
    link.href = "data:application/octet-stream;base64," + bytesBase64;
    document.body.appendChild(link); // Necesario para Firefox
    link.click();
    document.body.removeChild(link);
}