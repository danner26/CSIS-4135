function toggleHeader(callback) {
  let docHeader = document.getElementsByClassName("jumbotron")[0];

  switch (docHeader.style.display) {
    case "":
      docHeader.style.display = "none";
      callback.innerHTML = "Show Header";
      break;
    case "none":
      docHeader.style.display = "";
      callback.innerHTML = "Hide Header";
      break;
    default:
      console.log("ERROR, no display type");
      break;
  }
}
