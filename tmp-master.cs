# TMP MASTER

-----------------------------------------------------------------------------------

# Laravel 11 Breeze Blade #
$ composer create-project laravel/laravel example-app // command automatically create new SQLite @ database/database.sqlite to store app data.

$ php artisan serve // for test
// or more powerfull
$ composer run dev // run: artisan-server + npm run dev

$ composer require laravel/breeze --dev
$ php artisan breeze:install blade // blade without vue and etc.
$ composer run dev

// http://127.0.0.1:8000

#

web.php - middleware 
> auth		// logged-in users.
> verified  // (!) if enabled email verification.

#

$ php artisan make:model -mrc Chirp // model | migration | controller

$ Route::resource('chirps', ChirpController::class)->only(['index', 'store'])->middleware(['auth', 'verified']);

#

$ php artisan db:show
$ php artisan db:table users
$ php artisan migrate
$ php artisan migrate:fresh

#

$ php artisan tinker // query console
$ App\Models\Chirp::all();

# Laravel 11 Breeze Blade #


# Migrations #
$table->foreignId('user_id')->constrained()->cascadeOnDelete();
// Equivalent to:
$table->unsignedBigInteger('user_id');
$table->foreign('user_id')->references('id')->on('users');
# Migrations #

358501234567
qqqqqq
Olaf