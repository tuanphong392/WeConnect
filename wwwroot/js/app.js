/* =============================================================
   WeConnect — Giai đoạn 1: JS thuần cho tương tác giao diện.
   Không có nghiệp vụ thật, chỉ mở/đóng, chuyển tab, ẩn/hiện...
   ============================================================= */

document.addEventListener('DOMContentLoaded', function () {

  /* ---------- Thu gọn / mở rộng sidebar ---------- */
  document.querySelectorAll('[data-toggle-sidebar]').forEach(function (btn) {
    btn.addEventListener('click', function () {
      document.body.classList.toggle('collapsed');
    });
  });

  /* ---------- Dropdown chung (mở/đóng + đóng khi click ngoài) ---------- */
  document.querySelectorAll('.dropdown').forEach(function (dd) {
    dd.addEventListener('click', function (e) {
      e.stopPropagation();
      dd.classList.toggle('open');
      // Đóng các dropdown khác
      document.querySelectorAll('.dropdown.open').forEach(function (o) {
        if (o !== dd) o.classList.remove('open');
      });
    });
  });
  document.addEventListener('click', function () {
    document.querySelectorAll('.dropdown.open').forEach(function (o) { o.classList.remove('open'); });
    document.querySelectorAll('.menu.open').forEach(function (o) { o.classList.remove('open'); });
  });

  /* ---------- Ẩn / hiện mật khẩu ---------- */
  document.querySelectorAll('[data-toggle-pass]').forEach(function (btn) {
    btn.addEventListener('click', function () {
      var input = document.getElementById(btn.getAttribute('data-toggle-pass'));
      if (!input) return;
      var show = input.type === 'password';
      input.type = show ? 'text' : 'password';
      btn.textContent = show ? '🙈' : '👁';
    });
  });

  /* ---------- Tabs (đăng nhập / chat / sidebar...) ---------- */
  document.querySelectorAll('[data-tabs]').forEach(function (group) {
    var tabs = group.querySelectorAll('[data-tab]');
    tabs.forEach(function (tab) {
      tab.addEventListener('click', function () {
        tabs.forEach(function (t) { t.classList.remove('active'); });
        tab.classList.add('active');
        var target = tab.getAttribute('data-tab');
        var panels = group.parentElement.querySelectorAll('[data-tab-panel]');
        panels.forEach(function (p) {
          p.style.display = (p.getAttribute('data-tab-panel') === target) ? '' : 'none';
        });
      });
    });
  });

  /* ---------- Modal chung ---------- */
  document.querySelectorAll('[data-open-modal]').forEach(function (btn) {
    btn.addEventListener('click', function () {
      var id = btn.getAttribute('data-open-modal');
      var modal = document.getElementById(id);
      if (modal) modal.classList.add('open');
    });
  });
  document.querySelectorAll('[data-close-modal]').forEach(function (btn) {
    btn.addEventListener('click', function () {
      var modal = btn.closest('.modal-overlay');
      if (modal) modal.classList.remove('open');
    });
  });
  document.querySelectorAll('.modal-overlay').forEach(function (modal) {
    modal.addEventListener('click', function (e) {
      if (e.target === modal) modal.classList.remove('open');
    });
  });
  document.addEventListener('keydown', function (e) {
    if (e.key === 'Escape') {
      document.querySelectorAll('.modal-overlay.open').forEach(function (m) { m.classList.remove('open'); });
    }
  });

  /* ---------- Dropdown chọn mục (cập nhật chữ trên chip) ---------- */
  document.querySelectorAll('[data-menu]').forEach(function (trigger) {
    trigger.addEventListener('click', function (e) {
      e.stopPropagation();
      var menu = document.getElementById(trigger.getAttribute('data-menu'));
      if (!menu) return;
      // đóng menu khác
      document.querySelectorAll('.menu.open').forEach(function (o) { if (o !== menu) o.classList.remove('open'); });
      menu.classList.toggle('open');
      // căn menu dưới chip
      var rect = trigger.getBoundingClientRect();
      menu.style.position = 'fixed';
      menu.style.top = (rect.bottom + 6) + 'px';
      menu.style.left = rect.left + 'px';
    });
  });
  document.querySelectorAll('.menu-item[data-pick]').forEach(function (item) {
    item.addEventListener('click', function () {
      var menu = item.closest('.menu');
      var trigger = document.querySelector('[data-menu="' + menu.id + '"]');
      if (trigger) {
        var label = trigger.querySelector('[data-chip-label]');
        if (label) label.textContent = item.getAttribute('data-pick');
      }
      // đánh dấu ✓
      menu.querySelectorAll('.menu-item .check').forEach(function (c) { c.textContent = ''; });
      var check = item.querySelector('.check');
      if (check) check.textContent = '✓';
      menu.classList.remove('open');
    });
  });

  /* ---------- Calendar đơn giản (chỉ giao diện) ---------- */
  document.querySelectorAll('[data-calendar-prev]').forEach(function (b) {
    b.addEventListener('click', function (e) { e.stopPropagation(); });
  });
  document.querySelectorAll('[data-calendar-next]').forEach(function (b) {
    b.addEventListener('click', function (e) { e.stopPropagation(); });
  });
  document.querySelectorAll('.calendar-day').forEach(function (d) {
    d.addEventListener('click', function () {
      var menu = d.closest('.menu');
      var trigger = document.querySelector('[data-menu="' + menu.id + '"]');
      if (trigger) {
        var label = trigger.querySelector('[data-chip-label]');
        if (label) label.textContent = d.textContent.trim() + ' Th10, 2026';
      }
      menu.classList.remove('open');
    });
  });

  /* ---------- Thông báo: đánh dấu đã đọc / xóa tất cả ---------- */
  var markAll = document.getElementById('notif-mark-all');
  if (markAll) {
    markAll.addEventListener('click', function () {
      document.querySelectorAll('.notif-item').forEach(function (i) { i.classList.add('read'); });
    });
  }
  var clearAll = document.getElementById('notif-clear-all');
  if (clearAll) {
    clearAll.addEventListener('click', function () {
      var list = document.getElementById('notif-list');
      if (list) list.innerHTML = '<div style="padding:24px;text-align:center;color:var(--text-3);font-size:13px;">Không có thông báo nào.</div>';
      // ẩn chấm đỏ trên chuông
      var dot = document.getElementById('notif-dot');
      if (dot) dot.style.display = 'none';
    });
  }

  /* ---------- Toggle switch (ma trận quyền) ---------- */
  document.querySelectorAll('.toggle[data-toggle-switch]').forEach(function (t) {
    t.addEventListener('click', function () {
      t.classList.toggle('on');
    });
  });

  /* ---------- Chat: đổi hội thoại ---------- */
  document.querySelectorAll('.conversation[data-conv]').forEach(function (c) {
    c.addEventListener('click', function () {
      document.querySelectorAll('.conversation').forEach(function (x) { x.classList.remove('active'); });
      c.classList.add('active');
      var name = c.getAttribute('data-name') || 'Nguyễn Văn An';
      var avatar = c.getAttribute('data-avatar') || 'NA';
      var email = c.getAttribute('data-email') || '';
      var status = c.getAttribute('data-status') || 'Đang hoạt động';
      var tplId = c.getAttribute('data-tpl') || 'chat-tpl-default';

      var nameEl = document.getElementById('chat-name');
      var statusEl = document.getElementById('chat-status');
      var avatarEl = document.getElementById('chat-avatar');
      var inputPh = document.getElementById('chat-input');
      if (nameEl) nameEl.textContent = name;
      if (statusEl) statusEl.textContent = status;
      if (avatarEl) avatarEl.textContent = avatar;
      if (inputPh) inputPh.placeholder = 'Nhập tin nhắn cho ' + name + '...';

      var tpl = document.getElementById(tplId);
      var msgBox = document.getElementById('chat-messages');
      if (msgBox && tpl) msgBox.innerHTML = tpl.innerHTML;

      // thông tin bên phải
      var ciName = document.getElementById('ci-name');
      var ciEmail = document.getElementById('ci-email');
      if (ciName) ciName.textContent = name;
      if (ciEmail) ciEmail.textContent = email || '';
    });
  });

});
