var gulp = require('gulp');
var concat = require('gulp-concat');
var uglify = require('gulp-uglify');
var sourcemaps = require('gulp-sourcemaps');
var del = require('del');
 
var paths = {
  css: ['wwwroot/css/**/*.css']
};
 
gulp.task('clean', function() {
  return del(['build']);
});
 
gulp.task('scripts', ['clean'], function () {
    var files = [
        "wwwroot/js/jquery.min.js",
        "wwwroot/js/bootstrap.min.js",
        "wwwroot/js/chart.min.js",
        "wwwroot/js/moment-with-locales.min.js",
        "wwwroot/js/nprogress.js",
        "wwwroot/js/custom.min.js"
    ];
  return gulp.src(files)
      .pipe(uglify())
      .pipe(concat('all.min.js'))
    .pipe(gulp.dest('wwwroot/build/js'));
});
 
gulp.task('watch', function() {
  gulp.watch(paths.scripts, ['scripts']);
});