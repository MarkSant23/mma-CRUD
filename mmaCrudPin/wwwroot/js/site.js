// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//(($) => {
//     Index = () => {
//        var $this = this;
//         initialize = ()=> {

//            $(".popup").on('click',(e) => {
//                modelPopup(this);
//            });

//             modelPopup =(reff)=> {
//                var url = $(reff).data('url');

//                $.get(url).done((data) => {
//                    debugger;
//                    $('#modal-create-edit-user').find(".modal-dialog").html(data);
//                    $('#modal-create-edit-user > .modal', data).modal("show");
//                });

//            }
//        }

//        $this.init = () => {
//            initialize();
//        };
//    }
//    $(() => {
//        var self = new Index();
//        self.init();
//    });
//}(jQuery));  