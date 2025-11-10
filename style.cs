CSS - PROJETO FINAL 
:root{
    --main-color: skyblue
}


.btn{

     width: 50px;
    height: 50px;
    background-color: var(--main-color);
    color: aliceblue;
    border-radius: 10px;
    border: none;

}

main{

    height: 100vh;
    width: 100vw;
    display: flex;
    justify-content: center;
    align-items: center;

}

.button:hover{

    background-color: red
}

@keyframes minhaAnimação {

    0%{ transform: translateX(50px);}
    25%{ background-color: blue ;
        color: var(--main-color);}
    50%{ transform: translateX(50px);}
    75%{ transform: translateX(0px);}
    100%{ transform: translateY(0);}

}

.btn{

    animation: minhaAnimação 1s ease-in-out infinite alternate;
    opacity: 0.7;
    
}

___________________________________________________________________________________________________________


.whatsapp-button {
  position: fixed;
  bottom: 25px;
  right: 25px;
  background-color: #25d366;
  border-radius: 50%;
  width: 60px;
  height: 60px;
  display: flex;
  justify-content: center;
  align-items: center;
  box-shadow: 0 4px 10px rgba(0, 0, 0, 0.3);
  transition: transform 0.3s ease, box-shadow 0.3s ease;
  z-index: 1000;
}

.whatsapp-button:hover {
  transform: scale(1.1);
  box-shadow: 0 6px 15px rgba(0, 0, 0, 0.4);
}

.whatsapp-button img {
  width: 35px;
  height: 35px;
  filter: invert(1);
}
