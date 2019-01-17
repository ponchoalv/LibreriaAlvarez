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

function readFileById(inputFile) {
    var uploadFile = document.getElementById(inputFile);
    const temporaryFileReader = new FileReader();

    return new Promise((resolve, reject) => {

        temporaryFileReader.onerror = () => {
            temporaryFileReader.abort();
            reject(new DOMException("Ocurrió un problema al intentar la carga del archivo."));
        };

        temporaryFileReader.addEventListener("load", function () {

            var data = temporaryFileReader.result.split(',')[1]
            resolve(data);
   
        }, false);

        temporaryFileReader.readAsDataURL(uploadFile.files[0]);
    });
}