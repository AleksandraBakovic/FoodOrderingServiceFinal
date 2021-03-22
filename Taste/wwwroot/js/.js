var dataTable;

$(document).ready(function () {
    loadList();
});

function loadList() {
    dataTable = $('#DT_load').DataTable({
        "ajax": {
            "url": "/api/user",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "fullName", "width": "25%" },
            { "data": "email", "width": "25%" },
            { "data": "phoneNumber", "width": "25%" },
            {
                "data": {id:"id",lockoutEnd:"lockoutEnd"},
                "render": function (data) {
                    var today = new Date().getTime();
                    var lockout = new Date(data.lockoutEnd).getTime();
                    if (lockout > today) {
                        //currently user is locked
                        return ` <div class="text-center">
                                <a class="btn btn-block text-white button-confirm hvr-wobble-horizontal " style="background-color:rgba(191, 155, 56, 0.84) !important" onclick=LockUnlock('${data.id}')>
                                   <i class="fas fa-lock-open"></i> Odblokiraj
                                </a></div>`;

                    }
                    else {
                        return ` <div class="text-center">
                                <a class="btn btn-block text-white button-confirm hvr-wobble-horizontal " style="background-color:rgba(30, 28, 28, 0.89) !important" onclick=LockUnlock('${data.id}')>
                                    <i class="fas fa-lock"></i> Blokiraj
                                </a></div>`;
                    }
                   
                }, "width": "30%"
            }
        ],
        "language": {
            "url": "//cdn.datatables.net/plug-ins/9dcbecd42ad/i18n/Serbian.json",
            "emptyTable": "Nema podataka!"
        },
        "width": "100%"
    });
}

function LockUnlock(id) {
   
            $.ajax({
                type: 'POST',
                url: '/api/User',
                data: JSON.stringify(id),
                contentType:"application/json",
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            });
   
}