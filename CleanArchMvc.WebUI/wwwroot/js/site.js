$(document).ready(function () {
  /*  alert('worked');*/

    function OpenAddPopup() {
        //title text
        $("#AddUpdateModelLabel").text("Add Supplier")
        //clear all input
        ClearAllInput();
        //open popup
        $('#AddUpdateModel').modal('show');
        //show add patient button and hide update button
        $('#btnUpdatepatient').hide();
        $('#btnAddpatient').show();
    }
    function AddPatient() {
        var res = ValidateUserInput();
        if (res == false) {
            return false;
        }
        var patientObj = {
            Id: $('#Id').val(),
            Code: $('#txtCode').val(),
            Name: $('#txtName').val(),
            TelephoneNumber: $('#txtTelephone').val()

        };
        $.ajax({
            url: "/Suppliers/AddSupplier",
            data: JSON.stringify(patientObj),
            type: "POST",
            contentType: "application/json;charset=utf-8",
            dataType: "json",
            success: function (result) {
                //populate table with new record
                BindpatientData();
                //claer all input and hide model popup
                ClearAllInput();
                $('#AddUpdateModel').modal('hide');
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
    }
});