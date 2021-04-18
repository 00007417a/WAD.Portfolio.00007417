var stage;

// method for initializing a viewer
function init() {
  var canvas = document.getElementById("360viewer");
  if (!canvas || !canvas.getContext) return;

  stage = new createjs.Stage(canvas);
  stage.enableMouseOver(true);
  stage.mouseMoveOutside = true;
    createjs.Touch.enable(stage);

// array of string of images
  var imgList = [
      "../images/360/16.jpg",
      "../images/360/1.jpg",
      "../images/360/2.jpg",
      "../images/360/3.jpg",
      "../images/360/4.jpg",
      "../images/360/5.jpg",
      "../images/360/6.jpg",
      "../images/360/7.jpg",
      "../images/360/8.jpg",
      "../images/360/9.jpg",
      "../images/360/10.jpg",
      "../images/360/11.jpg",
      "../images/360/12.jpg",
      "../images/360/13.jpg",
      "../images/360/14.jpg",
      "../images/360/15.jpg"

    ];

  var images = [],
    loaded = 0,
    currentFrame = 0,
    totalFrames = imgList.length;
  var rotate360Interval, start_x;

  var bg = new createjs.Shape();
  stage.addChild(bg);

  var bmp = new createjs.Bitmap();
  stage.addChild(bmp);

  function load360Image() {
    var img = new Image();
    img.src = imgList[loaded];
    img.onload = img360Loaded;
    images[loaded] = img;
  }

  function img360Loaded(event) {
    loaded++;
    bg.graphics.clear()
    bg.graphics.endFill();

    if (loaded == totalFrames) start360();
    else load360Image();
  }

  function start360() {
    document.body.style.cursor = 'none';

    // update-draw
    update360(0);

    // first rotation
    rotate360Interval = setInterval(function() {
      if (currentFrame === totalFrames - 1) {
        clearInterval(rotate360Interval);
        addNavigation();
      }
      update360(1);
    }, 60);
  }

  function iconLoaded(event) {
    var iconBmp = new createjs.Bitmap();
    iconBmp.image = event.target;
    iconBmp.x = 20;
    iconBmp.y = canvas.height - iconBmp.image.height - 20;
    stage.addChild(iconBmp);
  }

  function update360(dir) {
    currentFrame += dir;
    if (currentFrame < 0) currentFrame = totalFrames - 1;
    else if (currentFrame > totalFrames - 1) currentFrame = 0;
    bmp.image = images[currentFrame];
  }

  //------------------------------- 
  function addNavigation() {
    stage.onMouseOver = mouseOver;
    stage.onMouseDown = mousePressed;
    document.body.style.cursor = 'auto';
  }

  function mouseOver(event) {
    document.body.style.cursor = 'pointer';
  }

  function mousePressed(event) {
    start_x = event.rawX;
    stage.onMouseMove = mouseMoved;
    stage.onMouseUp = mouseUp;

    document.body.style.cursor = 'w-resize';
  }

  function mouseMoved(event) {
    var dx = event.rawX - start_x;
    var abs_dx = Math.abs(dx);

    if (abs_dx > 5) {
      update360(dx / abs_dx);
      start_x = event.rawX;
    }
  }

  function mouseUp(event) {
    stage.onMouseMove = null;
    stage.onMouseUp = null;
    document.body.style.cursor = 'default';
  }

  function handleTick() {
    stage.update();
  }

  document.body.style.cursor = 'progress';
  load360Image();

  // rotation speed 
  createjs.Ticker.addEventListener("tick", handleTick);
  createjs.Ticker.setFPS(24);
  createjs.Ticker.useRAF = true;
}