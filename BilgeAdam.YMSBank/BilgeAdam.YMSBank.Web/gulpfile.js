var gulp = require('gulp');
var concat = require('gulp-concat');
var uglify = require('gulp-uglify');
var del = require('del');
 
gulp.task('cleanJs', function () {
    return del(['wwwroot/build/js/all.min.js']
    );
});

gulp.task('cleanCss', function () {
    return del(['wwwroot/build/css/all.min.css']
    );
});
 
gulp.task('scripts', ['cleanJs'], function () {
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

gulp.task('styles', ['cleanCss'], function () {
    var files = [
        "wwwroot/css/bootstrap.min.css",
        "wwwroot/css/font-awesome.min.css",
        "wwwroot/css/nprogress.css",
        "wwwroot/css/custom.min.css",
        "wwwroot/css/site.css"
    ];
    return gulp.src(files)
        .pipe(concat('all.min.css'))
        .pipe(gulp.dest('wwwroot/build/css'));
});
 
gulp.task('watch', function() {
  gulp.watch(paths.scripts, ['scripts']);
});