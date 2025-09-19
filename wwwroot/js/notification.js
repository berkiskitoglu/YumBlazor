window.ShowToastr = function (type, message){
    if (type == "success") {
        toastr.success(message);
    }
    if (type == "warning") {
        toastr.warning(message);
    }
}