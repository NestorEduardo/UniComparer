$('#btn-search').on('click', function (e) {

    let params = new URLSearchParams(window.location.search);
    let gradeCategoryId = params.get('gradeCategoryId');
    let search = $('#Search').val();

    $.ajax({
        type: 'GET',
        url: 'GradesByGradeCategory',
        contentType: 'application/json; charset=utf-8',
        data: { gradeCategoryId: gradeCategoryId, search: search, partialView: true },
        dataType: 'json',
        complete: function (response) {
            $('#grades-result').replaceWith(response.responseText);

            if (!$('.single-result').length) {
                $('#results').html('No se encontraron resultados con los criterios especificados.');
            }
        }
    });
});
