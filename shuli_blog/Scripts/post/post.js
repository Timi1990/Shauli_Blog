

function copyImageUrl(fileId, nameId) {
    var path = $("#" + fileId).val();
    var parsedPath = path.substring(path.lastIndexOf('\\') + 1, path.length);
    $("#" + nameId).val(parsedPath);
}