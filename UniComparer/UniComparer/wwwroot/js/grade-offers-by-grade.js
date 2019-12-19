$('#GradeOfferSortingOption').on('change', function () {
    let params = new URLSearchParams(window.location.search);
    let gradeId = params.get('gradeId');
    let gradeOfferSortingOption = this.value;
    $.ajax({
        type: 'GET',
        url: 'GradeOffersByGrade',
        contentType: 'application/json; charset=utf-8',
        data: { gradeId: gradeId, gradeOfferSortingOption: gradeOfferSortingOption, partialView: true },
        dataType: 'json',
        complete: function (response) {
            $('#grade-offers-result').html(response.responseText);
        }
    });
});