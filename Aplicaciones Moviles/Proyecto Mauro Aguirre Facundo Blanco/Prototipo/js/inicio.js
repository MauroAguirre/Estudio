$(document).ready(function(){
    
    $("#btnIng").click(Ingresar);
    $("#btnPerfil").click(Perfil);
    $("#btnReg").click(Registrar);
    //$("#inicio").hide();
})
function Registrar(){
    $("img").animate({
        left: "-=300",
    }, 1500, function() {

        $("#Registrar").animate({
            left: "-=320",
        }, 1500, function() {
            // Animation complete.
        });

    });
    $("#txtUsu").animate({
        left: "-=300",
      }, 1500, function() {
        // Animation complete.
      });
    $("#pwdCon").animate({
        left: "-=300",
    }, 1500, function() {
        // Animation complete.
    });
    $("#btnIng").animate({
        left: "-=300",
      }, 1500, function() {
        // Animation complete.
      });
    $("#btnReg").animate({
        left: "-=300",
    }, 1500, function() {
        // Animation complete.
    });
}
function Ingresar(){
    
    $("img").animate({
        left: "-=300",
    }, 1500, function() {

        $("#MenuPrincipalDiv").animate({
            left: "-=320",
        }, 1500, function() {
            // Animation complete.
        });
        $("#btnClientes").animate({
            left: "-=300",
        }, 1500, function() {
            // Animation complete.
        });
        $("#btnRuta").animate({
            left: "-=300",
        }, 1500, function() {
            // Animation complete.
        });
        $("#btnPerfil").animate({
            left: "-=300",
        }, 1500, function() {
            // Animation complete.
        });
        $("#btnNotificaciones").animate({
            left: "-=300",
        }, 1500, function() {
            // Animation complete.
        });

    });
    $("#txtUsu").animate({
        left: "-=300",
      }, 1500, function() {
        // Animation complete.
      });
    $("#pwdCon").animate({
        left: "-=300",
    }, 1500, function() {
        // Animation complete.
    });
    $("#btnIng").animate({
        left: "-=300",
      }, 1500, function() {
        // Animation complete.
      });
    $("#btnReg").animate({
        left: "-=300",
    }, 1500, function() {
        // Animation complete.
    });
}
function Perfil(){
    $("#MenuPrincipalDiv").animate({
        left: "-=320",
    }, 1500, function() {
        
        $("#PerfilDiv").animate({
            left: "-=320",
        }, 1500, function() {
            // Animation complete.
        });
        $("#PerfilBody").animate({
            left: "-=320",
        }, 1500, function() {
            // Animation complete.
        });

    });
    $("#btnClientes").animate({
        left: "-=300",
    }, 1500, function() {
        // Animation complete.
    });
    $("#btnRuta").animate({
        left: "-=300",
    }, 1500, function() {
        // Animation complete.
    });
    $("#btnPerfil").animate({
        left: "-=300",
    }, 1500, function() {
        // Animation complete.
    });
    $("#btnNotificaciones").animate({
        left: "-=300",
    }, 1500, function() {
        // Animation complete.
    });
}