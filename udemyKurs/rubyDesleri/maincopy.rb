# frozen_string_literal: true

class NumberGenerator
  attr_accessor :attempts_left, :lower, :upper

  DEFAULT_LOWER = 1
  DEFAULT_UPPER = 100
  DEFAULT_ATTEMPTS = 3

  def initialize(attempts = DEFAULT_ATTEMPTS)
    @attempts_left = attempts
    @lower = DEFAULT_LOWER
    @upper = DEFAULT_UPPER
  end

  def reset
    @attempts_left = DEFAULT_ATTEMPTS
    @lower = DEFAULT_LOWER
    @upper = DEFAULT_UPPER
  end

  def setup(lower, upper)
    @lower = lower
    @upper = upper
  end

  def call
    if @attempts_left > 0
      @attempts_left -= 1
      @num = rand(@lower..@upper)
      puts @num
      return @num
    else
      puts "No more attempts left"
      return nil
    end
  end

  def last
    if @num.nil?
      puts "No numbers generated yet"
      return nil
    else
      puts @num
      return @num
    end
  end
end

# Ask the user to enter the number of attempts for the generator
puts "Choose a number of attempts for the number generator:"
attempts = gets.to_i

# Create a new NumberGenerator object with the given number of attempts
generator = NumberGenerator.new(attempts)

# Loop until the user enters "exit"
loop do
  # Print the available options
  puts "Choose an operation:"
  puts "call --> generate a new number"
  puts "last --> show the last generated number"
  puts "reset --> reset the generator"
  puts "setup --> set the range of numbers"
  puts "attempts_left --> show the remaining attempts"
  puts "lower --> show the lower limit"
  puts "upper --> show the upper limit"
  puts "exit --> quit the program"

  # Get the user's choice and convert it to lowercase
  choice = gets.chomp.downcase

  case choice
  when "call"
    generator.call
  when "last"
    generator.last
  when "reset"
    generator.reset
  when "setup"
    puts "Enter lower limit:"
    lower = gets.to_i
    puts "Enter upper limit:"
    upper = gets.to_i
    generator.setup(lower, upper)
  when "attempts_left"
    puts generator.attempts_left
  when "lower"
    puts generator.lower
  when "upper"
    puts generator.upper
  when "exit"
    # Exit the loop and quit the program
    break
  else
    # If the user enters an invalid choice, print an error message
    puts "Invalid choice"
  end
end
