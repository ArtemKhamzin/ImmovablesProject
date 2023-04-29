function showOrHidePassword(btnClicked, input) {
    $(btnClicked).on("click", function () {
        let isHidden = $(input).attr("type") === 'password'
        $(input).attr('type', isHidden ? 'text' : 'password')
    })
}

let skipElementsForRent = 2
let takeElementsForRent = 2

$('#show-more-rent').click(function (){
    $.ajax({
        type: "get",
        url: `Rent?handler=MoreImmovablesForRent&skip=${skipElementsForRent}&take=${takeElementsForRent}`,
        success: function (html) {
            $('#ImmovableForRent').append(html)
        }
    })

    skipElementsForRent += takeElementsForRent
})

$(document).ready(function () {
    $('#myImg').click(function(){
        $('#myModal').css('display', "block");
        $('#img01').attr('src', this.src);
    })
    $('.close1')[0].onclick = function() {
        $('#myModal').css('display', "none");
    }

    $('#myImg2').click(function(){
        $('#myModal2').css('display', "block");
        $('#img02').attr('src', this.src);
    })
    $('.close2')[0].onclick = function() {
        $('#myModal2').css('display', "none");
    }
})

let skipElementsForSale = 2
let takeElementsForSale = 2

$('#show-more-sale').click(function (){
    $.ajax({
        type: "get",
        url: `SalePage?handler=MoreImmovablesForSale&skip=${skipElementsForSale}&take=${takeElementsForSale}`,
        success: function (html) {
            $('#ImmovableForSale').append(html)
        }
    })

    skipElementsForSale += takeElementsForSale
})

showOrHidePassword($('#show-password-btn'), $('#password-input'))