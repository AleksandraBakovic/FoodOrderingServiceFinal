var dataTable;

$(document).ready(function () {
    loadList();
});

function loadList() {
    dataTable = $('#DT_load').DataTable({
        "ajax": {
            "url": "/api/category",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "name", "width": "40%" },
            { "data": "displayOrder", "width": "30%" },
            {
                "data": "id",
                "render": function (data) {
                    return ` <div class="text-center">
                                <a href="/Admin/category/upsert?id=${data}" class="btn btn-block text-white button-confirm hvr-wobble-horizontal " style="background-color:rgba(191, 155, 56, 0.84) !important">
                                    <i class="far fa-edit"></i> Izmeni
                                </a>
                                <a class="btn btn-block text-white button-confirm hvr-wobble-horizontal " style="background-color:rgba(30, 28, 28, 0.89) !important" onclick=Delete('/api/category/'+${data})>
                                    <i class="far fa-trash-alt"></i> Obriši
                                </a>
                    </div>`;
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

function Delete(url) {
    swal({
        title: "Da li ste sigurni da želite da obrišete kategoriju?",
        text: "Nećete biti u mogućnosti da vratite podatke!",
        icon: "warning",
        buttons: true,
        dangerMode: true
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: 'DELETE',
                url: url,
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
    });
}