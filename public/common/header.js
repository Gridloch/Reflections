
document.write(`<a href="/home/kitchen/index.html"><img src="/common/Images/Banner.png" class="center"></a>\
      <div class="topNav">\
        <div class="dropdown">\
          <button class="${activeNav==="home" ? 'navButton, active' : 'navButton'}"><a href="/home/kitchen/index.html">Home</a></button>\
          <div class="dropdown-content">\
            <a href="/home/kitchen/index.html">Kitchen</a>\
            <a href="/home/living room/index.html">Living Room</a>\
            <a href="/home/garden/index.html">Garden</a>\
          </div>\
        </div>\
        <div class="dropdown">\
          <button class="${activeNav==="town" ? 'navButton, active' : 'navButton'}"><a href="/town/main map/index.html">Town</a></button>\
        </div>\
        <div class="dropdown">\
          <button class="${activeNav==="lore" ? 'navButton, active' : 'navButton'},"><a href="#">Lore</a></button>\
        </div>\
      </div>`
);