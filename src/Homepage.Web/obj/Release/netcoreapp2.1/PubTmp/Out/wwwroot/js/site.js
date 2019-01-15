// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

particlesJS.load('particles-js', 'particles.json', function () {
    console.log('callback - particles.js config loaded');
});

var typed = new Typed(".typed-text", {
	/**
	 * @property {array} strings strings to be typed
	 * @property {string} stringsElement ID of element containing string children
	 */
	strings: ['Thorsten Alpers.', 'ein Softwareentwickler.'/*, 'ein Softwarearchitekt.'*/ ],
	stringsElement: null,

	/**
	 * @property {number} typeSpeed type speed in milliseconds
	 */
	typeSpeed: 110,

	/**
	 * @property {number} startDelay time before typing starts in milliseconds
	 */
	startDelay: 1000,

	/**
	 * @property {number} backSpeed backspacing speed in milliseconds
	 */
	backSpeed: 100,

	/**
	 * @property {boolean} smartBackspace only backspace what doesn't match the previous string
	 */
	smartBackspace: false,

	/**
	 * @property {boolean} shuffle shuffle the strings
	 */
	shuffle: false,

	/**
	 * @property {number} backDelay time before backspacing in milliseconds
	 */
	backDelay: 700,

	/**
	 * @property {boolean} fadeOut Fade out instead of backspace
	 * @property {string} fadeOutClass css class for fade animation
	 * @property {boolean} fadeOutDelay Fade out delay in milliseconds
	 */
	fadeOut: false,
	fadeOutClass: 'typed-fade-out',
	fadeOutDelay: 500,

	/**
	 * @property {boolean} loop loop strings
	 * @property {number} loopCount amount of loops
	 */
	loop: true,
	loopCount: Infinity,

	/**
	 * @property {boolean} showCursor show cursor
	 * @property {string} cursorChar character for cursor
	 * @property {boolean} autoInsertCss insert CSS for cursor and fadeOut into HTML <head>
	 */
	showCursor: true,
	cursorChar: '|',
	autoInsertCss: true,

	/**
	 * @property {string} attr attribute for typing
	 * Ex: input placeholder, value, or just HTML text
	 */
	attr: null,

	/**
	 * @property {boolean} bindInputFocusEvents bind to focus and blur if el is text input
	 */
	bindInputFocusEvents: false,

	/**
	 * @property {string} contentType 'html' or 'null' for plaintext
	 */
	contentType: 'html',

	///**
	// * All typing is complete
	// * @param {Typed} self
	// */
	//onComplete: (self) => { },

	///**
	// * Before each string is typed
	// * @param {number} arrayPos
	// * @param {Typed} self
	// */
	//preStringTyped: (arrayPos, self) => { },

	///**
	// * After each string is typed
	// * @param {number} arrayPos
	// * @param {Typed} self
	// */
	//onStringTyped: (arrayPos, self) => { },

	///**
	// * During looping, after last string is typed
	// * @param {Typed} self
	// */
	//onLastStringBackspaced: (self) => { },

	///**
	// * Typing has been stopped
	// * @param {number} arrayPos
	// * @param {Typed} self
	// */
	//onTypingPaused: (arrayPos, self) => { },

	///**
	// * Typing has been started after being stopped
	// * @param {number} arrayPos
	// * @param {Typed} self
	// */
	//onTypingResumed: (arrayPos, self) => { },

	///**
	// * After reset
	// * @param {Typed} self
	// */
	//onReset: (self) => { },

	///**
	// * After stop
	// * @param {number} arrayPos
	// * @param {Typed} self
	// */
	//onStop: (arrayPos, self) => { },

	///**
	// * After start
	// * @param {number} arrayPos
	// * @param {Typed} self
	// */
	//onStart: (arrayPos, self) => { },

	///**
	// * After destroy
	// * @param {Typed} self
	// */
	//onDestroy: (self) => { }
});
